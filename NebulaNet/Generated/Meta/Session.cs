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

  public partial class Session : TBase
  {
    private long _session_id;
    private long _create_time;
    private long _update_time;
    private byte[] _user_name;
    private byte[] _space_name;
    private global::Nebula.Common.HostAddr _graph_addr;
    private int _timezone;
    private byte[] _client_ip;
    private Dictionary<byte[], global::Nebula.Common.@Value> _configs;
    private Dictionary<long, global::Nebula.Meta.QueryDesc> _queries;

    public long Session_id
    {
      get
      {
        return _session_id;
      }
      set
      {
        __isset.session_id = true;
        this._session_id = value;
      }
    }

    public long Create_time
    {
      get
      {
        return _create_time;
      }
      set
      {
        __isset.create_time = true;
        this._create_time = value;
      }
    }

    public long Update_time
    {
      get
      {
        return _update_time;
      }
      set
      {
        __isset.update_time = true;
        this._update_time = value;
      }
    }

    public byte[] User_name
    {
      get
      {
        return _user_name;
      }
      set
      {
        __isset.user_name = true;
        this._user_name = value;
      }
    }

    public byte[] Space_name
    {
      get
      {
        return _space_name;
      }
      set
      {
        __isset.space_name = true;
        this._space_name = value;
      }
    }

    public global::Nebula.Common.HostAddr Graph_addr
    {
      get
      {
        return _graph_addr;
      }
      set
      {
        __isset.graph_addr = true;
        this._graph_addr = value;
      }
    }

    public int Timezone
    {
      get
      {
        return _timezone;
      }
      set
      {
        __isset.timezone = true;
        this._timezone = value;
      }
    }

    public byte[] Client_ip
    {
      get
      {
        return _client_ip;
      }
      set
      {
        __isset.client_ip = true;
        this._client_ip = value;
      }
    }

    public Dictionary<byte[], global::Nebula.Common.@Value> Configs
    {
      get
      {
        return _configs;
      }
      set
      {
        __isset.configs = true;
        this._configs = value;
      }
    }

    public Dictionary<long, global::Nebula.Meta.QueryDesc> Queries
    {
      get
      {
        return _queries;
      }
      set
      {
        __isset.queries = true;
        this._queries = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool session_id;
      public bool create_time;
      public bool update_time;
      public bool user_name;
      public bool space_name;
      public bool graph_addr;
      public bool timezone;
      public bool client_ip;
      public bool configs;
      public bool queries;
    }

    public Session()
    {
    }

    public Session DeepCopy()
    {
      var tmp1028 = new Session();
      if(__isset.session_id)
      {
        tmp1028.Session_id = this.Session_id;
      }
      tmp1028.__isset.session_id = this.__isset.session_id;
      if(__isset.create_time)
      {
        tmp1028.Create_time = this.Create_time;
      }
      tmp1028.__isset.create_time = this.__isset.create_time;
      if(__isset.update_time)
      {
        tmp1028.Update_time = this.Update_time;
      }
      tmp1028.__isset.update_time = this.__isset.update_time;
      if((User_name != null) && __isset.user_name)
      {
        tmp1028.User_name = this.User_name.ToArray();
      }
      tmp1028.__isset.user_name = this.__isset.user_name;
      if((Space_name != null) && __isset.space_name)
      {
        tmp1028.Space_name = this.Space_name.ToArray();
      }
      tmp1028.__isset.space_name = this.__isset.space_name;
      if((Graph_addr != null) && __isset.graph_addr)
      {
        tmp1028.Graph_addr = (global::Nebula.Common.HostAddr)this.Graph_addr.DeepCopy();
      }
      tmp1028.__isset.graph_addr = this.__isset.graph_addr;
      if(__isset.timezone)
      {
        tmp1028.Timezone = this.Timezone;
      }
      tmp1028.__isset.timezone = this.__isset.timezone;
      if((Client_ip != null) && __isset.client_ip)
      {
        tmp1028.Client_ip = this.Client_ip.ToArray();
      }
      tmp1028.__isset.client_ip = this.__isset.client_ip;
      if((Configs != null) && __isset.configs)
      {
        tmp1028.Configs = this.Configs.DeepCopy();
      }
      tmp1028.__isset.configs = this.__isset.configs;
      if((Queries != null) && __isset.queries)
      {
        tmp1028.Queries = this.Queries.DeepCopy();
      }
      tmp1028.__isset.queries = this.__isset.queries;
      return tmp1028;
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
              if (field.Type == TType.I64)
              {
                Session_id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                Create_time = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Update_time = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                User_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.String)
              {
                Space_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Struct)
              {
                Graph_addr = new global::Nebula.Common.HostAddr();
                await Graph_addr.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                Timezone = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.String)
              {
                Client_ip = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.Map)
              {
                {
                  TMap _map1029 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Configs = new Dictionary<byte[], global::Nebula.Common.@Value>(_map1029.Count);
                  for(int _i1030 = 0; _i1030 < _map1029.Count; ++_i1030)
                  {
                    byte[] _key1031;
                    global::Nebula.Common.@Value _val1032;
                    _key1031 = await iprot.ReadBinaryAsync(cancellationToken);
                    _val1032 = new global::Nebula.Common.@Value();
                    await _val1032.ReadAsync(iprot, cancellationToken);
                    Configs[_key1031] = _val1032;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.Map)
              {
                {
                  TMap _map1033 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Queries = new Dictionary<long, global::Nebula.Meta.QueryDesc>(_map1033.Count);
                  for(int _i1034 = 0; _i1034 < _map1033.Count; ++_i1034)
                  {
                    long _key1035;
                    global::Nebula.Meta.QueryDesc _val1036;
                    _key1035 = await iprot.ReadI64Async(cancellationToken);
                    _val1036 = new global::Nebula.Meta.QueryDesc();
                    await _val1036.ReadAsync(iprot, cancellationToken);
                    Queries[_key1035] = _val1036;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
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
        var tmp1037 = new TStruct("Session");
        await oprot.WriteStructBeginAsync(tmp1037, cancellationToken);
        var tmp1038 = new TField();
        if(__isset.session_id)
        {
          tmp1038.Name = "session_id";
          tmp1038.Type = TType.I64;
          tmp1038.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          await oprot.WriteI64Async(Session_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.create_time)
        {
          tmp1038.Name = "create_time";
          tmp1038.Type = TType.I64;
          tmp1038.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          await oprot.WriteI64Async(Create_time, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.update_time)
        {
          tmp1038.Name = "update_time";
          tmp1038.Type = TType.I64;
          tmp1038.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          await oprot.WriteI64Async(Update_time, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((User_name != null) && __isset.user_name)
        {
          tmp1038.Name = "user_name";
          tmp1038.Type = TType.String;
          tmp1038.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          await oprot.WriteBinaryAsync(User_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Space_name != null) && __isset.space_name)
        {
          tmp1038.Name = "space_name";
          tmp1038.Type = TType.String;
          tmp1038.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          await oprot.WriteBinaryAsync(Space_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Graph_addr != null) && __isset.graph_addr)
        {
          tmp1038.Name = "graph_addr";
          tmp1038.Type = TType.Struct;
          tmp1038.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          await Graph_addr.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.timezone)
        {
          tmp1038.Name = "timezone";
          tmp1038.Type = TType.I32;
          tmp1038.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          await oprot.WriteI32Async(Timezone, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Client_ip != null) && __isset.client_ip)
        {
          tmp1038.Name = "client_ip";
          tmp1038.Type = TType.String;
          tmp1038.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          await oprot.WriteBinaryAsync(Client_ip, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Configs != null) && __isset.configs)
        {
          tmp1038.Name = "configs";
          tmp1038.Type = TType.Map;
          tmp1038.ID = 9;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.Struct, Configs.Count), cancellationToken);
            foreach (byte[] _iter1039 in Configs.Keys)
            {
              await oprot.WriteBinaryAsync(_iter1039, cancellationToken);
              await Configs[_iter1039].WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Queries != null) && __isset.queries)
        {
          tmp1038.Name = "queries";
          tmp1038.Type = TType.Map;
          tmp1038.ID = 10;
          await oprot.WriteFieldBeginAsync(tmp1038, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.I64, TType.Struct, Queries.Count), cancellationToken);
            foreach (long _iter1040 in Queries.Keys)
            {
              await oprot.WriteI64Async(_iter1040, cancellationToken);
              await Queries[_iter1040].WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteMapEndAsync(cancellationToken);
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
      if (!(that is Session other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.session_id == other.__isset.session_id) && ((!__isset.session_id) || (System.Object.Equals(Session_id, other.Session_id))))
        && ((__isset.create_time == other.__isset.create_time) && ((!__isset.create_time) || (System.Object.Equals(Create_time, other.Create_time))))
        && ((__isset.update_time == other.__isset.update_time) && ((!__isset.update_time) || (System.Object.Equals(Update_time, other.Update_time))))
        && ((__isset.user_name == other.__isset.user_name) && ((!__isset.user_name) || (TCollections.Equals(User_name, other.User_name))))
        && ((__isset.space_name == other.__isset.space_name) && ((!__isset.space_name) || (TCollections.Equals(Space_name, other.Space_name))))
        && ((__isset.graph_addr == other.__isset.graph_addr) && ((!__isset.graph_addr) || (System.Object.Equals(Graph_addr, other.Graph_addr))))
        && ((__isset.timezone == other.__isset.timezone) && ((!__isset.timezone) || (System.Object.Equals(Timezone, other.Timezone))))
        && ((__isset.client_ip == other.__isset.client_ip) && ((!__isset.client_ip) || (TCollections.Equals(Client_ip, other.Client_ip))))
        && ((__isset.configs == other.__isset.configs) && ((!__isset.configs) || (TCollections.Equals(Configs, other.Configs))))
        && ((__isset.queries == other.__isset.queries) && ((!__isset.queries) || (TCollections.Equals(Queries, other.Queries))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.session_id)
        {
          hashcode = (hashcode * 397) + Session_id.GetHashCode();
        }
        if(__isset.create_time)
        {
          hashcode = (hashcode * 397) + Create_time.GetHashCode();
        }
        if(__isset.update_time)
        {
          hashcode = (hashcode * 397) + Update_time.GetHashCode();
        }
        if((User_name != null) && __isset.user_name)
        {
          hashcode = (hashcode * 397) + User_name.GetHashCode();
        }
        if((Space_name != null) && __isset.space_name)
        {
          hashcode = (hashcode * 397) + Space_name.GetHashCode();
        }
        if((Graph_addr != null) && __isset.graph_addr)
        {
          hashcode = (hashcode * 397) + Graph_addr.GetHashCode();
        }
        if(__isset.timezone)
        {
          hashcode = (hashcode * 397) + Timezone.GetHashCode();
        }
        if((Client_ip != null) && __isset.client_ip)
        {
          hashcode = (hashcode * 397) + Client_ip.GetHashCode();
        }
        if((Configs != null) && __isset.configs)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Configs);
        }
        if((Queries != null) && __isset.queries)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Queries);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp1041 = new StringBuilder("Session(");
      int tmp1042 = 0;
      if(__isset.session_id)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("Session_id: ");
        Session_id.ToString(tmp1041);
      }
      if(__isset.create_time)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("Create_time: ");
        Create_time.ToString(tmp1041);
      }
      if(__isset.update_time)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("Update_time: ");
        Update_time.ToString(tmp1041);
      }
      if((User_name != null) && __isset.user_name)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("User_name: ");
        User_name.ToString(tmp1041);
      }
      if((Space_name != null) && __isset.space_name)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("Space_name: ");
        Space_name.ToString(tmp1041);
      }
      if((Graph_addr != null) && __isset.graph_addr)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("Graph_addr: ");
        Graph_addr.ToString(tmp1041);
      }
      if(__isset.timezone)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("Timezone: ");
        Timezone.ToString(tmp1041);
      }
      if((Client_ip != null) && __isset.client_ip)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("Client_ip: ");
        Client_ip.ToString(tmp1041);
      }
      if((Configs != null) && __isset.configs)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("Configs: ");
        Configs.ToString(tmp1041);
      }
      if((Queries != null) && __isset.queries)
      {
        if(0 < tmp1042++) { tmp1041.Append(", "); }
        tmp1041.Append("Queries: ");
        Queries.ToString(tmp1041);
      }
      tmp1041.Append(')');
      return tmp1041.ToString();
    }
  }

}