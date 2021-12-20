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

  public partial class ListTagsResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private List<global::Nebula.Meta.TagItem> _tags;

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

    public List<global::Nebula.Meta.TagItem> Tags
    {
      get
      {
        return _tags;
      }
      set
      {
        __isset.tags = true;
        this._tags = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool tags;
    }

    public ListTagsResp()
    {
    }

    public ListTagsResp DeepCopy()
    {
      var tmp247 = new ListTagsResp();
      if(__isset.code)
      {
        tmp247.Code = this.Code;
      }
      tmp247.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp247.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp247.__isset.leader = this.__isset.leader;
      if((Tags != null) && __isset.tags)
      {
        tmp247.Tags = this.Tags.DeepCopy();
      }
      tmp247.__isset.tags = this.__isset.tags;
      return tmp247;
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
                  TList _list248 = await iprot.ReadListBeginAsync(cancellationToken);
                  Tags = new List<global::Nebula.Meta.TagItem>(_list248.Count);
                  for(int _i249 = 0; _i249 < _list248.Count; ++_i249)
                  {
                    global::Nebula.Meta.TagItem _elem250;
                    _elem250 = new global::Nebula.Meta.TagItem();
                    await _elem250.ReadAsync(iprot, cancellationToken);
                    Tags.Add(_elem250);
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
        var tmp251 = new TStruct("ListTagsResp");
        await oprot.WriteStructBeginAsync(tmp251, cancellationToken);
        var tmp252 = new TField();
        if(__isset.code)
        {
          tmp252.Name = "code";
          tmp252.Type = TType.I32;
          tmp252.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp252, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp252.Name = "leader";
          tmp252.Type = TType.Struct;
          tmp252.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp252, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Tags != null) && __isset.tags)
        {
          tmp252.Name = "tags";
          tmp252.Type = TType.List;
          tmp252.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp252, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Tags.Count), cancellationToken);
            foreach (global::Nebula.Meta.TagItem _iter253 in Tags)
            {
              await _iter253.WriteAsync(oprot, cancellationToken);
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
      if (!(that is ListTagsResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.tags == other.__isset.tags) && ((!__isset.tags) || (TCollections.Equals(Tags, other.Tags))));
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
        if((Tags != null) && __isset.tags)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Tags);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp254 = new StringBuilder("ListTagsResp(");
      int tmp255 = 0;
      if(__isset.code)
      {
        if(0 < tmp255++) { tmp254.Append(", "); }
        tmp254.Append("Code: ");
        Code.ToString(tmp254);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp255++) { tmp254.Append(", "); }
        tmp254.Append("Leader: ");
        Leader.ToString(tmp254);
      }
      if((Tags != null) && __isset.tags)
      {
        if(0 < tmp255++) { tmp254.Append(", "); }
        tmp254.Append("Tags: ");
        Tags.ToString(tmp254);
      }
      tmp254.Append(')');
      return tmp254.ToString();
    }
  }

}