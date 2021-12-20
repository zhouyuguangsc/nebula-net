/**
 * Autogenerated by Thrift Compiler (0.15.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Nebula.Meta
{

  public partial class ListEdgesResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private List<global::Nebula.Meta.EdgeItem> _edges;

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Common.ErrorCode"/>
    /// </summary>
    public global::Nebula.Common.ErrorCode Code
    {
      get
      {
        return _code;
      }
      set
      {
        __isset.code = true;
        this._code = value;
      }
    }

    public global::Nebula.Common.HostAddr Leader
    {
      get
      {
        return _leader;
      }
      set
      {
        __isset.leader = true;
        this._leader = value;
      }
    }

    public List<global::Nebula.Meta.EdgeItem> Edges
    {
      get
      {
        return _edges;
      }
      set
      {
        __isset.edges = true;
        this._edges = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool edges;
    }

    public ListEdgesResp()
    {
    }

    public ListEdgesResp DeepCopy()
    {
      var tmp300 = new ListEdgesResp();
      if(__isset.code)
      {
        tmp300.Code = this.Code;
      }
      tmp300.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp300.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp300.__isset.leader = this.__isset.leader;
      if((Edges != null) && __isset.edges)
      {
        tmp300.Edges = this.Edges.DeepCopy();
      }
      tmp300.__isset.edges = this.__isset.edges;
      return tmp300;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Code = (global::Nebula.Common.ErrorCode)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Leader = new global::Nebula.Common.HostAddr();
                await Leader.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.List)
              {
                {
                  TList _list301 = await iprot.ReadListBeginAsync(cancellationToken);
                  Edges = new List<global::Nebula.Meta.EdgeItem>(_list301.Count);
                  for(int _i302 = 0; _i302 < _list301.Count; ++_i302)
                  {
                    global::Nebula.Meta.EdgeItem _elem303;
                    _elem303 = new global::Nebula.Meta.EdgeItem();
                    await _elem303.ReadAsync(iprot, cancellationToken);
                    Edges.Add(_elem303);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp304 = new TStruct("ListEdgesResp");
        await oprot.WriteStructBeginAsync(tmp304, cancellationToken);
        var tmp305 = new TField();
        if(__isset.code)
        {
          tmp305.Name = "code";
          tmp305.Type = TType.I32;
          tmp305.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp305, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp305.Name = "leader";
          tmp305.Type = TType.Struct;
          tmp305.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp305, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Edges != null) && __isset.edges)
        {
          tmp305.Name = "edges";
          tmp305.Type = TType.List;
          tmp305.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp305, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Edges.Count), cancellationToken);
            foreach (global::Nebula.Meta.EdgeItem _iter306 in Edges)
            {
              await _iter306.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is ListEdgesResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.edges == other.__isset.edges) && ((!__isset.edges) || (TCollections.Equals(Edges, other.Edges))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.code)
        {
          hashcode = (hashcode * 397) + Code.GetHashCode();
        }
        if((Leader != null) && __isset.leader)
        {
          hashcode = (hashcode * 397) + Leader.GetHashCode();
        }
        if((Edges != null) && __isset.edges)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Edges);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp307 = new StringBuilder("ListEdgesResp(");
      int tmp308 = 0;
      if(__isset.code)
      {
        if(0 < tmp308++) { tmp307.Append(", "); }
        tmp307.Append("Code: ");
        Code.ToString(tmp307);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp308++) { tmp307.Append(", "); }
        tmp307.Append("Leader: ");
        Leader.ToString(tmp307);
      }
      if((Edges != null) && __isset.edges)
      {
        if(0 < tmp308++) { tmp307.Append(", "); }
        tmp307.Append("Edges: ");
        Edges.ToString(tmp307);
      }
      tmp307.Append(')');
      return tmp307.ToString();
    }
  }

}