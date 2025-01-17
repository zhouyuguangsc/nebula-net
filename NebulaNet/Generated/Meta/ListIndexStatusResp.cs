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

  public partial class ListIndexStatusResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private List<global::Nebula.Meta.IndexStatus> _statuses;

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

    public List<global::Nebula.Meta.IndexStatus> Statuses
    {
      get
      {
        return _statuses;
      }
      set
      {
        __isset.statuses = true;
        this._statuses = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool statuses;
    }

    public ListIndexStatusResp()
    {
    }

    public ListIndexStatusResp DeepCopy()
    {
      var tmp723 = new ListIndexStatusResp();
      if(__isset.code)
      {
        tmp723.Code = this.Code;
      }
      tmp723.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp723.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp723.__isset.leader = this.__isset.leader;
      if((Statuses != null) && __isset.statuses)
      {
        tmp723.Statuses = this.Statuses.DeepCopy();
      }
      tmp723.__isset.statuses = this.__isset.statuses;
      return tmp723;
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
                  TList _list724 = await iprot.ReadListBeginAsync(cancellationToken);
                  Statuses = new List<global::Nebula.Meta.IndexStatus>(_list724.Count);
                  for(int _i725 = 0; _i725 < _list724.Count; ++_i725)
                  {
                    global::Nebula.Meta.IndexStatus _elem726;
                    _elem726 = new global::Nebula.Meta.IndexStatus();
                    await _elem726.ReadAsync(iprot, cancellationToken);
                    Statuses.Add(_elem726);
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
        var tmp727 = new TStruct("ListIndexStatusResp");
        await oprot.WriteStructBeginAsync(tmp727, cancellationToken);
        var tmp728 = new TField();
        if(__isset.code)
        {
          tmp728.Name = "code";
          tmp728.Type = TType.I32;
          tmp728.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp728, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp728.Name = "leader";
          tmp728.Type = TType.Struct;
          tmp728.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp728, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Statuses != null) && __isset.statuses)
        {
          tmp728.Name = "statuses";
          tmp728.Type = TType.List;
          tmp728.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp728, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Statuses.Count), cancellationToken);
            foreach (global::Nebula.Meta.IndexStatus _iter729 in Statuses)
            {
              await _iter729.WriteAsync(oprot, cancellationToken);
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
      if (!(that is ListIndexStatusResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.statuses == other.__isset.statuses) && ((!__isset.statuses) || (TCollections.Equals(Statuses, other.Statuses))));
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
        if((Statuses != null) && __isset.statuses)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Statuses);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp730 = new StringBuilder("ListIndexStatusResp(");
      int tmp731 = 0;
      if(__isset.code)
      {
        if(0 < tmp731++) { tmp730.Append(", "); }
        tmp730.Append("Code: ");
        Code.ToString(tmp730);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp731++) { tmp730.Append(", "); }
        tmp730.Append("Leader: ");
        Leader.ToString(tmp730);
      }
      if((Statuses != null) && __isset.statuses)
      {
        if(0 < tmp731++) { tmp730.Append(", "); }
        tmp730.Append("Statuses: ");
        Statuses.ToString(tmp730);
      }
      tmp730.Append(')');
      return tmp730.ToString();
    }
  }

}
