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

  public partial class ListEdgeIndexesResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private List<global::Nebula.Meta.IndexItem> _items;

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

    public List<global::Nebula.Meta.IndexItem> Items
    {
      get
      {
        return _items;
      }
      set
      {
        __isset.items = true;
        this._items = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool items;
    }

    public ListEdgeIndexesResp()
    {
    }

    public ListEdgeIndexesResp DeepCopy()
    {
      var tmp535 = new ListEdgeIndexesResp();
      if(__isset.code)
      {
        tmp535.Code = this.Code;
      }
      tmp535.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp535.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp535.__isset.leader = this.__isset.leader;
      if((Items != null) && __isset.items)
      {
        tmp535.Items = this.Items.DeepCopy();
      }
      tmp535.__isset.items = this.__isset.items;
      return tmp535;
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
                  TList _list536 = await iprot.ReadListBeginAsync(cancellationToken);
                  Items = new List<global::Nebula.Meta.IndexItem>(_list536.Count);
                  for(int _i537 = 0; _i537 < _list536.Count; ++_i537)
                  {
                    global::Nebula.Meta.IndexItem _elem538;
                    _elem538 = new global::Nebula.Meta.IndexItem();
                    await _elem538.ReadAsync(iprot, cancellationToken);
                    Items.Add(_elem538);
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
        var tmp539 = new TStruct("ListEdgeIndexesResp");
        await oprot.WriteStructBeginAsync(tmp539, cancellationToken);
        var tmp540 = new TField();
        if(__isset.code)
        {
          tmp540.Name = "code";
          tmp540.Type = TType.I32;
          tmp540.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp540, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp540.Name = "leader";
          tmp540.Type = TType.Struct;
          tmp540.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp540, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Items != null) && __isset.items)
        {
          tmp540.Name = "items";
          tmp540.Type = TType.List;
          tmp540.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp540, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Items.Count), cancellationToken);
            foreach (global::Nebula.Meta.IndexItem _iter541 in Items)
            {
              await _iter541.WriteAsync(oprot, cancellationToken);
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
      if (!(that is ListEdgeIndexesResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.items == other.__isset.items) && ((!__isset.items) || (TCollections.Equals(Items, other.Items))));
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
        if((Items != null) && __isset.items)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Items);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp542 = new StringBuilder("ListEdgeIndexesResp(");
      int tmp543 = 0;
      if(__isset.code)
      {
        if(0 < tmp543++) { tmp542.Append(", "); }
        tmp542.Append("Code: ");
        Code.ToString(tmp542);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp543++) { tmp542.Append(", "); }
        tmp542.Append("Leader: ");
        Leader.ToString(tmp542);
      }
      if((Items != null) && __isset.items)
      {
        if(0 < tmp543++) { tmp542.Append(", "); }
        tmp542.Append("Items: ");
        Items.ToString(tmp542);
      }
      tmp542.Append(')');
      return tmp542.ToString();
    }
  }

}