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

  public partial class GetTagIndexResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private global::Nebula.Meta.IndexItem _item;

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

    public global::Nebula.Meta.IndexItem Item
    {
      get
      {
        return _item;
      }
      set
      {
        __isset.item = true;
        this._item = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool item;
    }

    public GetTagIndexResp()
    {
    }

    public GetTagIndexResp DeepCopy()
    {
      var tmp487 = new GetTagIndexResp();
      if(__isset.code)
      {
        tmp487.Code = this.Code;
      }
      tmp487.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp487.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp487.__isset.leader = this.__isset.leader;
      if((Item != null) && __isset.item)
      {
        tmp487.Item = (global::Nebula.Meta.IndexItem)this.Item.DeepCopy();
      }
      tmp487.__isset.item = this.__isset.item;
      return tmp487;
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
              if (field.Type == TType.Struct)
              {
                Item = new global::Nebula.Meta.IndexItem();
                await Item.ReadAsync(iprot, cancellationToken);
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
        var tmp488 = new TStruct("GetTagIndexResp");
        await oprot.WriteStructBeginAsync(tmp488, cancellationToken);
        var tmp489 = new TField();
        if(__isset.code)
        {
          tmp489.Name = "code";
          tmp489.Type = TType.I32;
          tmp489.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp489, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp489.Name = "leader";
          tmp489.Type = TType.Struct;
          tmp489.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp489, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Item != null) && __isset.item)
        {
          tmp489.Name = "item";
          tmp489.Type = TType.Struct;
          tmp489.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp489, cancellationToken);
          await Item.WriteAsync(oprot, cancellationToken);
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
      if (!(that is GetTagIndexResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.item == other.__isset.item) && ((!__isset.item) || (System.Object.Equals(Item, other.Item))));
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
        if((Item != null) && __isset.item)
        {
          hashcode = (hashcode * 397) + Item.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp490 = new StringBuilder("GetTagIndexResp(");
      int tmp491 = 0;
      if(__isset.code)
      {
        if(0 < tmp491++) { tmp490.Append(", "); }
        tmp490.Append("Code: ");
        Code.ToString(tmp490);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp491++) { tmp490.Append(", "); }
        tmp490.Append("Leader: ");
        Leader.ToString(tmp490);
      }
      if((Item != null) && __isset.item)
      {
        if(0 < tmp491++) { tmp490.Append(", "); }
        tmp490.Append("Item: ");
        Item.ToString(tmp490);
      }
      tmp490.Append(')');
      return tmp490.ToString();
    }
  }

}