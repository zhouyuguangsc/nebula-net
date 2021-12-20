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

namespace Nebula.Storage
{

  public partial class MemberChangeReq : TBase
  {
    private int _space_id;
    private int _part_id;
    private global::Nebula.Common.HostAddr _peer;
    private bool _add;

    public int Space_id
    {
      get
      {
        return _space_id;
      }
      set
      {
        __isset.space_id = true;
        this._space_id = value;
      }
    }

    public int Part_id
    {
      get
      {
        return _part_id;
      }
      set
      {
        __isset.part_id = true;
        this._part_id = value;
      }
    }

    public global::Nebula.Common.HostAddr Peer
    {
      get
      {
        return _peer;
      }
      set
      {
        __isset.peer = true;
        this._peer = value;
      }
    }

    public bool Add
    {
      get
      {
        return _add;
      }
      set
      {
        __isset.@add = true;
        this._add = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool part_id;
      public bool peer;
      public bool @add;
    }

    public MemberChangeReq()
    {
    }

    public MemberChangeReq DeepCopy()
    {
      var tmp441 = new MemberChangeReq();
      if(__isset.space_id)
      {
        tmp441.Space_id = this.Space_id;
      }
      tmp441.__isset.space_id = this.__isset.space_id;
      if(__isset.part_id)
      {
        tmp441.Part_id = this.Part_id;
      }
      tmp441.__isset.part_id = this.__isset.part_id;
      if((Peer != null) && __isset.peer)
      {
        tmp441.Peer = (global::Nebula.Common.HostAddr)this.Peer.DeepCopy();
      }
      tmp441.__isset.peer = this.__isset.peer;
      if(__isset.@add)
      {
        tmp441.Add = this.Add;
      }
      tmp441.__isset.@add = this.__isset.@add;
      return tmp441;
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
                Space_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Part_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                Peer = new global::Nebula.Common.HostAddr();
                await Peer.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Bool)
              {
                Add = await iprot.ReadBoolAsync(cancellationToken);
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
        var tmp442 = new TStruct("MemberChangeReq");
        await oprot.WriteStructBeginAsync(tmp442, cancellationToken);
        var tmp443 = new TField();
        if(__isset.space_id)
        {
          tmp443.Name = "space_id";
          tmp443.Type = TType.I32;
          tmp443.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp443, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.part_id)
        {
          tmp443.Name = "part_id";
          tmp443.Type = TType.I32;
          tmp443.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp443, cancellationToken);
          await oprot.WriteI32Async(Part_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Peer != null) && __isset.peer)
        {
          tmp443.Name = "peer";
          tmp443.Type = TType.Struct;
          tmp443.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp443, cancellationToken);
          await Peer.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.@add)
        {
          tmp443.Name = "add";
          tmp443.Type = TType.Bool;
          tmp443.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp443, cancellationToken);
          await oprot.WriteBoolAsync(Add, cancellationToken);
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
      if (!(that is MemberChangeReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.part_id == other.__isset.part_id) && ((!__isset.part_id) || (System.Object.Equals(Part_id, other.Part_id))))
        && ((__isset.peer == other.__isset.peer) && ((!__isset.peer) || (System.Object.Equals(Peer, other.Peer))))
        && ((__isset.@add == other.__isset.@add) && ((!__isset.@add) || (System.Object.Equals(Add, other.Add))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if(__isset.part_id)
        {
          hashcode = (hashcode * 397) + Part_id.GetHashCode();
        }
        if((Peer != null) && __isset.peer)
        {
          hashcode = (hashcode * 397) + Peer.GetHashCode();
        }
        if(__isset.@add)
        {
          hashcode = (hashcode * 397) + Add.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp444 = new StringBuilder("MemberChangeReq(");
      int tmp445 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp445++) { tmp444.Append(", "); }
        tmp444.Append("Space_id: ");
        Space_id.ToString(tmp444);
      }
      if(__isset.part_id)
      {
        if(0 < tmp445++) { tmp444.Append(", "); }
        tmp444.Append("Part_id: ");
        Part_id.ToString(tmp444);
      }
      if((Peer != null) && __isset.peer)
      {
        if(0 < tmp445++) { tmp444.Append(", "); }
        tmp444.Append("Peer: ");
        Peer.ToString(tmp444);
      }
      if(__isset.@add)
      {
        if(0 < tmp445++) { tmp444.Append(", "); }
        tmp444.Append("Add: ");
        Add.ToString(tmp444);
      }
      tmp444.Append(')');
      return tmp444.ToString();
    }
  }

}