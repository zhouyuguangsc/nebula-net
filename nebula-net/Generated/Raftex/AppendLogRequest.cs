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

namespace Nebula.Raftex
{

  public partial class AppendLogRequest : TBase
  {
    private int _space;
    private int _part;
    private long _current_term;
    private long _last_log_id;
    private long _committed_log_id;
    private string _leader_addr;
    private int _leader_port;
    private long _last_log_term_sent;
    private long _last_log_id_sent;
    private long _log_term;
    private List<global::Nebula.Raftex.LogEntry> _log_str_list;
    private bool _sending_snapshot;

    public int Space
    {
      get
      {
        return _space;
      }
      set
      {
        __isset.space = true;
        this._space = value;
      }
    }

    public int Part
    {
      get
      {
        return _part;
      }
      set
      {
        __isset.part = true;
        this._part = value;
      }
    }

    public long Current_term
    {
      get
      {
        return _current_term;
      }
      set
      {
        __isset.current_term = true;
        this._current_term = value;
      }
    }

    public long Last_log_id
    {
      get
      {
        return _last_log_id;
      }
      set
      {
        __isset.last_log_id = true;
        this._last_log_id = value;
      }
    }

    public long Committed_log_id
    {
      get
      {
        return _committed_log_id;
      }
      set
      {
        __isset.committed_log_id = true;
        this._committed_log_id = value;
      }
    }

    public string Leader_addr
    {
      get
      {
        return _leader_addr;
      }
      set
      {
        __isset.leader_addr = true;
        this._leader_addr = value;
      }
    }

    public int Leader_port
    {
      get
      {
        return _leader_port;
      }
      set
      {
        __isset.leader_port = true;
        this._leader_port = value;
      }
    }

    public long Last_log_term_sent
    {
      get
      {
        return _last_log_term_sent;
      }
      set
      {
        __isset.last_log_term_sent = true;
        this._last_log_term_sent = value;
      }
    }

    public long Last_log_id_sent
    {
      get
      {
        return _last_log_id_sent;
      }
      set
      {
        __isset.last_log_id_sent = true;
        this._last_log_id_sent = value;
      }
    }

    public long Log_term
    {
      get
      {
        return _log_term;
      }
      set
      {
        __isset.log_term = true;
        this._log_term = value;
      }
    }

    public List<global::Nebula.Raftex.LogEntry> Log_str_list
    {
      get
      {
        return _log_str_list;
      }
      set
      {
        __isset.log_str_list = true;
        this._log_str_list = value;
      }
    }

    public bool Sending_snapshot
    {
      get
      {
        return _sending_snapshot;
      }
      set
      {
        __isset.sending_snapshot = true;
        this._sending_snapshot = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space;
      public bool part;
      public bool current_term;
      public bool last_log_id;
      public bool committed_log_id;
      public bool leader_addr;
      public bool leader_port;
      public bool last_log_term_sent;
      public bool last_log_id_sent;
      public bool log_term;
      public bool log_str_list;
      public bool sending_snapshot;
    }

    public AppendLogRequest()
    {
    }

    public AppendLogRequest DeepCopy()
    {
      var tmp15 = new AppendLogRequest();
      if(__isset.space)
      {
        tmp15.Space = this.Space;
      }
      tmp15.__isset.space = this.__isset.space;
      if(__isset.part)
      {
        tmp15.Part = this.Part;
      }
      tmp15.__isset.part = this.__isset.part;
      if(__isset.current_term)
      {
        tmp15.Current_term = this.Current_term;
      }
      tmp15.__isset.current_term = this.__isset.current_term;
      if(__isset.last_log_id)
      {
        tmp15.Last_log_id = this.Last_log_id;
      }
      tmp15.__isset.last_log_id = this.__isset.last_log_id;
      if(__isset.committed_log_id)
      {
        tmp15.Committed_log_id = this.Committed_log_id;
      }
      tmp15.__isset.committed_log_id = this.__isset.committed_log_id;
      if((Leader_addr != null) && __isset.leader_addr)
      {
        tmp15.Leader_addr = this.Leader_addr;
      }
      tmp15.__isset.leader_addr = this.__isset.leader_addr;
      if(__isset.leader_port)
      {
        tmp15.Leader_port = this.Leader_port;
      }
      tmp15.__isset.leader_port = this.__isset.leader_port;
      if(__isset.last_log_term_sent)
      {
        tmp15.Last_log_term_sent = this.Last_log_term_sent;
      }
      tmp15.__isset.last_log_term_sent = this.__isset.last_log_term_sent;
      if(__isset.last_log_id_sent)
      {
        tmp15.Last_log_id_sent = this.Last_log_id_sent;
      }
      tmp15.__isset.last_log_id_sent = this.__isset.last_log_id_sent;
      if(__isset.log_term)
      {
        tmp15.Log_term = this.Log_term;
      }
      tmp15.__isset.log_term = this.__isset.log_term;
      if((Log_str_list != null) && __isset.log_str_list)
      {
        tmp15.Log_str_list = this.Log_str_list.DeepCopy();
      }
      tmp15.__isset.log_str_list = this.__isset.log_str_list;
      if(__isset.sending_snapshot)
      {
        tmp15.Sending_snapshot = this.Sending_snapshot;
      }
      tmp15.__isset.sending_snapshot = this.__isset.sending_snapshot;
      return tmp15;
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
                Space = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Part = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Current_term = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                Last_log_id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I64)
              {
                Committed_log_id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                Leader_addr = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                Leader_port = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.I64)
              {
                Last_log_term_sent = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.I64)
              {
                Last_log_id_sent = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.I64)
              {
                Log_term = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 11:
              if (field.Type == TType.List)
              {
                {
                  TList _list16 = await iprot.ReadListBeginAsync(cancellationToken);
                  Log_str_list = new List<global::Nebula.Raftex.LogEntry>(_list16.Count);
                  for(int _i17 = 0; _i17 < _list16.Count; ++_i17)
                  {
                    global::Nebula.Raftex.LogEntry _elem18;
                    _elem18 = new global::Nebula.Raftex.LogEntry();
                    await _elem18.ReadAsync(iprot, cancellationToken);
                    Log_str_list.Add(_elem18);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 12:
              if (field.Type == TType.Bool)
              {
                Sending_snapshot = await iprot.ReadBoolAsync(cancellationToken);
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
        var tmp19 = new TStruct("AppendLogRequest");
        await oprot.WriteStructBeginAsync(tmp19, cancellationToken);
        var tmp20 = new TField();
        if(__isset.space)
        {
          tmp20.Name = "space";
          tmp20.Type = TType.I32;
          tmp20.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteI32Async(Space, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.part)
        {
          tmp20.Name = "part";
          tmp20.Type = TType.I32;
          tmp20.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteI32Async(Part, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.current_term)
        {
          tmp20.Name = "current_term";
          tmp20.Type = TType.I64;
          tmp20.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteI64Async(Current_term, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.last_log_id)
        {
          tmp20.Name = "last_log_id";
          tmp20.Type = TType.I64;
          tmp20.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteI64Async(Last_log_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.committed_log_id)
        {
          tmp20.Name = "committed_log_id";
          tmp20.Type = TType.I64;
          tmp20.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteI64Async(Committed_log_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader_addr != null) && __isset.leader_addr)
        {
          tmp20.Name = "leader_addr";
          tmp20.Type = TType.String;
          tmp20.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteStringAsync(Leader_addr, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.leader_port)
        {
          tmp20.Name = "leader_port";
          tmp20.Type = TType.I32;
          tmp20.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteI32Async(Leader_port, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.last_log_term_sent)
        {
          tmp20.Name = "last_log_term_sent";
          tmp20.Type = TType.I64;
          tmp20.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteI64Async(Last_log_term_sent, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.last_log_id_sent)
        {
          tmp20.Name = "last_log_id_sent";
          tmp20.Type = TType.I64;
          tmp20.ID = 9;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteI64Async(Last_log_id_sent, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.log_term)
        {
          tmp20.Name = "log_term";
          tmp20.Type = TType.I64;
          tmp20.ID = 10;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteI64Async(Log_term, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Log_str_list != null) && __isset.log_str_list)
        {
          tmp20.Name = "log_str_list";
          tmp20.Type = TType.List;
          tmp20.ID = 11;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Log_str_list.Count), cancellationToken);
            foreach (global::Nebula.Raftex.LogEntry _iter21 in Log_str_list)
            {
              await _iter21.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.sending_snapshot)
        {
          tmp20.Name = "sending_snapshot";
          tmp20.Type = TType.Bool;
          tmp20.ID = 12;
          await oprot.WriteFieldBeginAsync(tmp20, cancellationToken);
          await oprot.WriteBoolAsync(Sending_snapshot, cancellationToken);
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
      if (!(that is AppendLogRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space == other.__isset.space) && ((!__isset.space) || (System.Object.Equals(Space, other.Space))))
        && ((__isset.part == other.__isset.part) && ((!__isset.part) || (System.Object.Equals(Part, other.Part))))
        && ((__isset.current_term == other.__isset.current_term) && ((!__isset.current_term) || (System.Object.Equals(Current_term, other.Current_term))))
        && ((__isset.last_log_id == other.__isset.last_log_id) && ((!__isset.last_log_id) || (System.Object.Equals(Last_log_id, other.Last_log_id))))
        && ((__isset.committed_log_id == other.__isset.committed_log_id) && ((!__isset.committed_log_id) || (System.Object.Equals(Committed_log_id, other.Committed_log_id))))
        && ((__isset.leader_addr == other.__isset.leader_addr) && ((!__isset.leader_addr) || (System.Object.Equals(Leader_addr, other.Leader_addr))))
        && ((__isset.leader_port == other.__isset.leader_port) && ((!__isset.leader_port) || (System.Object.Equals(Leader_port, other.Leader_port))))
        && ((__isset.last_log_term_sent == other.__isset.last_log_term_sent) && ((!__isset.last_log_term_sent) || (System.Object.Equals(Last_log_term_sent, other.Last_log_term_sent))))
        && ((__isset.last_log_id_sent == other.__isset.last_log_id_sent) && ((!__isset.last_log_id_sent) || (System.Object.Equals(Last_log_id_sent, other.Last_log_id_sent))))
        && ((__isset.log_term == other.__isset.log_term) && ((!__isset.log_term) || (System.Object.Equals(Log_term, other.Log_term))))
        && ((__isset.log_str_list == other.__isset.log_str_list) && ((!__isset.log_str_list) || (TCollections.Equals(Log_str_list, other.Log_str_list))))
        && ((__isset.sending_snapshot == other.__isset.sending_snapshot) && ((!__isset.sending_snapshot) || (System.Object.Equals(Sending_snapshot, other.Sending_snapshot))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space)
        {
          hashcode = (hashcode * 397) + Space.GetHashCode();
        }
        if(__isset.part)
        {
          hashcode = (hashcode * 397) + Part.GetHashCode();
        }
        if(__isset.current_term)
        {
          hashcode = (hashcode * 397) + Current_term.GetHashCode();
        }
        if(__isset.last_log_id)
        {
          hashcode = (hashcode * 397) + Last_log_id.GetHashCode();
        }
        if(__isset.committed_log_id)
        {
          hashcode = (hashcode * 397) + Committed_log_id.GetHashCode();
        }
        if((Leader_addr != null) && __isset.leader_addr)
        {
          hashcode = (hashcode * 397) + Leader_addr.GetHashCode();
        }
        if(__isset.leader_port)
        {
          hashcode = (hashcode * 397) + Leader_port.GetHashCode();
        }
        if(__isset.last_log_term_sent)
        {
          hashcode = (hashcode * 397) + Last_log_term_sent.GetHashCode();
        }
        if(__isset.last_log_id_sent)
        {
          hashcode = (hashcode * 397) + Last_log_id_sent.GetHashCode();
        }
        if(__isset.log_term)
        {
          hashcode = (hashcode * 397) + Log_term.GetHashCode();
        }
        if((Log_str_list != null) && __isset.log_str_list)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Log_str_list);
        }
        if(__isset.sending_snapshot)
        {
          hashcode = (hashcode * 397) + Sending_snapshot.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp22 = new StringBuilder("AppendLogRequest(");
      int tmp23 = 0;
      if(__isset.space)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Space: ");
        Space.ToString(tmp22);
      }
      if(__isset.part)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Part: ");
        Part.ToString(tmp22);
      }
      if(__isset.current_term)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Current_term: ");
        Current_term.ToString(tmp22);
      }
      if(__isset.last_log_id)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Last_log_id: ");
        Last_log_id.ToString(tmp22);
      }
      if(__isset.committed_log_id)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Committed_log_id: ");
        Committed_log_id.ToString(tmp22);
      }
      if((Leader_addr != null) && __isset.leader_addr)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Leader_addr: ");
        Leader_addr.ToString(tmp22);
      }
      if(__isset.leader_port)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Leader_port: ");
        Leader_port.ToString(tmp22);
      }
      if(__isset.last_log_term_sent)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Last_log_term_sent: ");
        Last_log_term_sent.ToString(tmp22);
      }
      if(__isset.last_log_id_sent)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Last_log_id_sent: ");
        Last_log_id_sent.ToString(tmp22);
      }
      if(__isset.log_term)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Log_term: ");
        Log_term.ToString(tmp22);
      }
      if((Log_str_list != null) && __isset.log_str_list)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Log_str_list: ");
        Log_str_list.ToString(tmp22);
      }
      if(__isset.sending_snapshot)
      {
        if(0 < tmp23++) { tmp22.Append(", "); }
        tmp22.Append("Sending_snapshot: ");
        Sending_snapshot.ToString(tmp22);
      }
      tmp22.Append(')');
      return tmp22.ToString();
    }
  }

}
