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

  public partial class HostItem : TBase
  {
    private global::Nebula.Common.HostAddr _hostAddr;
    private global::Nebula.Meta.HostStatus _status;
    private Dictionary<byte[], List<int>> _leader_parts;
    private Dictionary<byte[], List<int>> _all_parts;
    private global::Nebula.Meta.HostRole _role;
    private byte[] _git_info_sha;
    private byte[] _zone_name;
    private byte[] _version;

    public global::Nebula.Common.HostAddr HostAddr
    {
      get
      {
        return _hostAddr;
      }
      set
      {
        __isset.hostAddr = true;
        this._hostAddr = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Meta.HostStatus"/>
    /// </summary>
    public global::Nebula.Meta.HostStatus Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }

    public Dictionary<byte[], List<int>> Leader_parts
    {
      get
      {
        return _leader_parts;
      }
      set
      {
        __isset.leader_parts = true;
        this._leader_parts = value;
      }
    }

    public Dictionary<byte[], List<int>> All_parts
    {
      get
      {
        return _all_parts;
      }
      set
      {
        __isset.all_parts = true;
        this._all_parts = value;
      }
    }

    public global::Nebula.Meta.HostRole Role
    {
      get
      {
        return _role;
      }
      set
      {
        __isset.role = true;
        this._role = value;
      }
    }

    public byte[] Git_info_sha
    {
      get
      {
        return _git_info_sha;
      }
      set
      {
        __isset.git_info_sha = true;
        this._git_info_sha = value;
      }
    }

    public byte[] Zone_name
    {
      get
      {
        return _zone_name;
      }
      set
      {
        __isset.zone_name = true;
        this._zone_name = value;
      }
    }

    public byte[] Version
    {
      get
      {
        return _version;
      }
      set
      {
        __isset.version = true;
        this._version = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool hostAddr;
      public bool status;
      public bool leader_parts;
      public bool all_parts;
      public bool role;
      public bool git_info_sha;
      public bool zone_name;
      public bool version;
    }

    public HostItem()
    {
    }

    public HostItem DeepCopy()
    {
      var tmp68 = new HostItem();
      if((HostAddr != null) && __isset.hostAddr)
      {
        tmp68.HostAddr = (global::Nebula.Common.HostAddr)this.HostAddr.DeepCopy();
      }
      tmp68.__isset.hostAddr = this.__isset.hostAddr;
      if(__isset.status)
      {
        tmp68.Status = this.Status;
      }
      tmp68.__isset.status = this.__isset.status;
      if((Leader_parts != null) && __isset.leader_parts)
      {
        tmp68.Leader_parts = this.Leader_parts.DeepCopy();
      }
      tmp68.__isset.leader_parts = this.__isset.leader_parts;
      if((All_parts != null) && __isset.all_parts)
      {
        tmp68.All_parts = this.All_parts.DeepCopy();
      }
      tmp68.__isset.all_parts = this.__isset.all_parts;
      if(__isset.role)
      {
        tmp68.Role = this.Role;
      }
      tmp68.__isset.role = this.__isset.role;
      if((Git_info_sha != null) && __isset.git_info_sha)
      {
        tmp68.Git_info_sha = this.Git_info_sha.ToArray();
      }
      tmp68.__isset.git_info_sha = this.__isset.git_info_sha;
      if((Zone_name != null) && __isset.zone_name)
      {
        tmp68.Zone_name = this.Zone_name.ToArray();
      }
      tmp68.__isset.zone_name = this.__isset.zone_name;
      if((Version != null) && __isset.version)
      {
        tmp68.Version = this.Version.ToArray();
      }
      tmp68.__isset.version = this.__isset.version;
      return tmp68;
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
              if (field.Type == TType.Struct)
              {
                HostAddr = new global::Nebula.Common.HostAddr();
                await HostAddr.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Status = (global::Nebula.Meta.HostStatus)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Map)
              {
                {
                  TMap _map69 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Leader_parts = new Dictionary<byte[], List<int>>(_map69.Count);
                  for(int _i70 = 0; _i70 < _map69.Count; ++_i70)
                  {
                    byte[] _key71;
                    List<int> _val72;
                    _key71 = await iprot.ReadBinaryAsync(cancellationToken);
                    {
                      TList _list73 = await iprot.ReadListBeginAsync(cancellationToken);
                      _val72 = new List<int>(_list73.Count);
                      for(int _i74 = 0; _i74 < _list73.Count; ++_i74)
                      {
                        int _elem75;
                        _elem75 = await iprot.ReadI32Async(cancellationToken);
                        _val72.Add(_elem75);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    Leader_parts[_key71] = _val72;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Map)
              {
                {
                  TMap _map76 = await iprot.ReadMapBeginAsync(cancellationToken);
                  All_parts = new Dictionary<byte[], List<int>>(_map76.Count);
                  for(int _i77 = 0; _i77 < _map76.Count; ++_i77)
                  {
                    byte[] _key78;
                    List<int> _val79;
                    _key78 = await iprot.ReadBinaryAsync(cancellationToken);
                    {
                      TList _list80 = await iprot.ReadListBeginAsync(cancellationToken);
                      _val79 = new List<int>(_list80.Count);
                      for(int _i81 = 0; _i81 < _list80.Count; ++_i81)
                      {
                        int _elem82;
                        _elem82 = await iprot.ReadI32Async(cancellationToken);
                        _val79.Add(_elem82);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    All_parts[_key78] = _val79;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I32)
              {
                Role = (global::Nebula.Meta.HostRole)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                Git_info_sha = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.String)
              {
                Zone_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.String)
              {
                Version = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp83 = new TStruct("HostItem");
        await oprot.WriteStructBeginAsync(tmp83, cancellationToken);
        var tmp84 = new TField();
        if((HostAddr != null) && __isset.hostAddr)
        {
          tmp84.Name = "hostAddr";
          tmp84.Type = TType.Struct;
          tmp84.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp84, cancellationToken);
          await HostAddr.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.status)
        {
          tmp84.Name = "status";
          tmp84.Type = TType.I32;
          tmp84.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp84, cancellationToken);
          await oprot.WriteI32Async((int)Status, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader_parts != null) && __isset.leader_parts)
        {
          tmp84.Name = "leader_parts";
          tmp84.Type = TType.Map;
          tmp84.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp84, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.List, Leader_parts.Count), cancellationToken);
            foreach (byte[] _iter85 in Leader_parts.Keys)
            {
              await oprot.WriteBinaryAsync(_iter85, cancellationToken);
              {
                await oprot.WriteListBeginAsync(new TList(TType.I32, Leader_parts[_iter85].Count), cancellationToken);
                foreach (int _iter86 in Leader_parts[_iter85])
                {
                  await oprot.WriteI32Async(_iter86, cancellationToken);
                }
                await oprot.WriteListEndAsync(cancellationToken);
              }
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((All_parts != null) && __isset.all_parts)
        {
          tmp84.Name = "all_parts";
          tmp84.Type = TType.Map;
          tmp84.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp84, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.List, All_parts.Count), cancellationToken);
            foreach (byte[] _iter87 in All_parts.Keys)
            {
              await oprot.WriteBinaryAsync(_iter87, cancellationToken);
              {
                await oprot.WriteListBeginAsync(new TList(TType.I32, All_parts[_iter87].Count), cancellationToken);
                foreach (int _iter88 in All_parts[_iter87])
                {
                  await oprot.WriteI32Async(_iter88, cancellationToken);
                }
                await oprot.WriteListEndAsync(cancellationToken);
              }
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.role)
        {
          tmp84.Name = "role";
          tmp84.Type = TType.I32;
          tmp84.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp84, cancellationToken);
          await oprot.WriteI32Async((int)Role, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Git_info_sha != null) && __isset.git_info_sha)
        {
          tmp84.Name = "git_info_sha";
          tmp84.Type = TType.String;
          tmp84.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp84, cancellationToken);
          await oprot.WriteBinaryAsync(Git_info_sha, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Zone_name != null) && __isset.zone_name)
        {
          tmp84.Name = "zone_name";
          tmp84.Type = TType.String;
          tmp84.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp84, cancellationToken);
          await oprot.WriteBinaryAsync(Zone_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Version != null) && __isset.version)
        {
          tmp84.Name = "version";
          tmp84.Type = TType.String;
          tmp84.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp84, cancellationToken);
          await oprot.WriteBinaryAsync(Version, cancellationToken);
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
      if (!(that is HostItem other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.hostAddr == other.__isset.hostAddr) && ((!__isset.hostAddr) || (System.Object.Equals(HostAddr, other.HostAddr))))
        && ((__isset.status == other.__isset.status) && ((!__isset.status) || (System.Object.Equals(Status, other.Status))))
        && ((__isset.leader_parts == other.__isset.leader_parts) && ((!__isset.leader_parts) || (TCollections.Equals(Leader_parts, other.Leader_parts))))
        && ((__isset.all_parts == other.__isset.all_parts) && ((!__isset.all_parts) || (TCollections.Equals(All_parts, other.All_parts))))
        && ((__isset.role == other.__isset.role) && ((!__isset.role) || (System.Object.Equals(Role, other.Role))))
        && ((__isset.git_info_sha == other.__isset.git_info_sha) && ((!__isset.git_info_sha) || (TCollections.Equals(Git_info_sha, other.Git_info_sha))))
        && ((__isset.zone_name == other.__isset.zone_name) && ((!__isset.zone_name) || (TCollections.Equals(Zone_name, other.Zone_name))))
        && ((__isset.version == other.__isset.version) && ((!__isset.version) || (TCollections.Equals(Version, other.Version))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((HostAddr != null) && __isset.hostAddr)
        {
          hashcode = (hashcode * 397) + HostAddr.GetHashCode();
        }
        if(__isset.status)
        {
          hashcode = (hashcode * 397) + Status.GetHashCode();
        }
        if((Leader_parts != null) && __isset.leader_parts)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Leader_parts);
        }
        if((All_parts != null) && __isset.all_parts)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(All_parts);
        }
        if(__isset.role)
        {
          hashcode = (hashcode * 397) + Role.GetHashCode();
        }
        if((Git_info_sha != null) && __isset.git_info_sha)
        {
          hashcode = (hashcode * 397) + Git_info_sha.GetHashCode();
        }
        if((Zone_name != null) && __isset.zone_name)
        {
          hashcode = (hashcode * 397) + Zone_name.GetHashCode();
        }
        if((Version != null) && __isset.version)
        {
          hashcode = (hashcode * 397) + Version.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp89 = new StringBuilder("HostItem(");
      int tmp90 = 0;
      if((HostAddr != null) && __isset.hostAddr)
      {
        if(0 < tmp90++) { tmp89.Append(", "); }
        tmp89.Append("HostAddr: ");
        HostAddr.ToString(tmp89);
      }
      if(__isset.status)
      {
        if(0 < tmp90++) { tmp89.Append(", "); }
        tmp89.Append("Status: ");
        Status.ToString(tmp89);
      }
      if((Leader_parts != null) && __isset.leader_parts)
      {
        if(0 < tmp90++) { tmp89.Append(", "); }
        tmp89.Append("Leader_parts: ");
        Leader_parts.ToString(tmp89);
      }
      if((All_parts != null) && __isset.all_parts)
      {
        if(0 < tmp90++) { tmp89.Append(", "); }
        tmp89.Append("All_parts: ");
        All_parts.ToString(tmp89);
      }
      if(__isset.role)
      {
        if(0 < tmp90++) { tmp89.Append(", "); }
        tmp89.Append("Role: ");
        Role.ToString(tmp89);
      }
      if((Git_info_sha != null) && __isset.git_info_sha)
      {
        if(0 < tmp90++) { tmp89.Append(", "); }
        tmp89.Append("Git_info_sha: ");
        Git_info_sha.ToString(tmp89);
      }
      if((Zone_name != null) && __isset.zone_name)
      {
        if(0 < tmp90++) { tmp89.Append(", "); }
        tmp89.Append("Zone_name: ");
        Zone_name.ToString(tmp89);
      }
      if((Version != null) && __isset.version)
      {
        if(0 < tmp90++) { tmp89.Append(", "); }
        tmp89.Append("Version: ");
        Version.ToString(tmp89);
      }
      tmp89.Append(')');
      return tmp89.ToString();
    }
  }

}
