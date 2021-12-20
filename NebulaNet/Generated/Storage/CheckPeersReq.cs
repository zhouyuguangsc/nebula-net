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

  public partial class CheckPeersReq : TBase
  {
    private int _space_id;
    private int _part_id;
    private List<global::Nebula.Common.HostAddr> _peers;

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

    public List<global::Nebula.Common.HostAddr> Peers
    {
      get
      {
        return _peers;
      }
      set
      {
        __isset.peers = true;
        this._peers = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool part_id;
      public bool peers;
    }

    public CheckPeersReq()
    {
    }

    public CheckPeersReq DeepCopy()
    {
      var tmp484 = new CheckPeersReq();
      if(__isset.space_id)
      {
        tmp484.Space_id = this.Space_id;
      }
      tmp484.__isset.space_id = this.__isset.space_id;
      if(__isset.part_id)
      {
        tmp484.Part_id = this.Part_id;
      }
      tmp484.__isset.part_id = this.__isset.part_id;
      if((Peers != null) && __isset.peers)
      {
        tmp484.Peers = this.Peers.DeepCopy();
      }
      tmp484.__isset.peers = this.__isset.peers;
      return tmp484;
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
              if (field.Type == TType.List)
              {
                {
                  TList _list485 = await iprot.ReadListBeginAsync(cancellationToken);
                  Peers = new List<global::Nebula.Common.HostAddr>(_list485.Count);
                  for(int _i486 = 0; _i486 < _list485.Count; ++_i486)
                  {
                    global::Nebula.Common.HostAddr _elem487;
                    _elem487 = new global::Nebula.Common.HostAddr();
                    await _elem487.ReadAsync(iprot, cancellationToken);
                    Peers.Add(_elem487);
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
        var tmp488 = new TStruct("CheckPeersReq");
        await oprot.WriteStructBeginAsync(tmp488, cancellationToken);
        var tmp489 = new TField();
        if(__isset.space_id)
        {
          tmp489.Name = "space_id";
          tmp489.Type = TType.I32;
          tmp489.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp489, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.part_id)
        {
          tmp489.Name = "part_id";
          tmp489.Type = TType.I32;
          tmp489.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp489, cancellationToken);
          await oprot.WriteI32Async(Part_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Peers != null) && __isset.peers)
        {
          tmp489.Name = "peers";
          tmp489.Type = TType.List;
          tmp489.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp489, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Peers.Count), cancellationToken);
            foreach (global::Nebula.Common.HostAddr _iter490 in Peers)
            {
              await _iter490.WriteAsync(oprot, cancellationToken);
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
      if (!(that is CheckPeersReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.part_id == other.__isset.part_id) && ((!__isset.part_id) || (System.Object.Equals(Part_id, other.Part_id))))
        && ((__isset.peers == other.__isset.peers) && ((!__isset.peers) || (TCollections.Equals(Peers, other.Peers))));
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
        if((Peers != null) && __isset.peers)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Peers);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp491 = new StringBuilder("CheckPeersReq(");
      int tmp492 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp492++) { tmp491.Append(", "); }
        tmp491.Append("Space_id: ");
        Space_id.ToString(tmp491);
      }
      if(__isset.part_id)
      {
        if(0 < tmp492++) { tmp491.Append(", "); }
        tmp491.Append("Part_id: ");
        Part_id.ToString(tmp491);
      }
      if((Peers != null) && __isset.peers)
      {
        if(0 < tmp492++) { tmp491.Append(", "); }
        tmp491.Append("Peers: ");
        Peers.ToString(tmp491);
      }
      tmp491.Append(')');
      return tmp491.ToString();
    }
  }

}