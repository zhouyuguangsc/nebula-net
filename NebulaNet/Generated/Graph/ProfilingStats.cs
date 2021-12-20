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

namespace Nebula.Graph
{

  public partial class ProfilingStats : TBase
  {
    private Dictionary<byte[], byte[]> _other_stats;

    public long Rows { get; set; }

    public long Exec_duration_in_us { get; set; }

    public long Total_duration_in_us { get; set; }

    public Dictionary<byte[], byte[]> Other_stats
    {
      get
      {
        return _other_stats;
      }
      set
      {
        __isset.other_stats = true;
        this._other_stats = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool other_stats;
    }

    public ProfilingStats()
    {
    }

    public ProfilingStats(long rows, long exec_duration_in_us, long total_duration_in_us) : this()
    {
      this.Rows = rows;
      this.Exec_duration_in_us = exec_duration_in_us;
      this.Total_duration_in_us = total_duration_in_us;
    }

    public ProfilingStats DeepCopy()
    {
      var tmp0 = new ProfilingStats();
      tmp0.Rows = this.Rows;
      tmp0.Exec_duration_in_us = this.Exec_duration_in_us;
      tmp0.Total_duration_in_us = this.Total_duration_in_us;
      if((Other_stats != null) && __isset.other_stats)
      {
        tmp0.Other_stats = this.Other_stats.DeepCopy();
      }
      tmp0.__isset.other_stats = this.__isset.other_stats;
      return tmp0;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_rows = false;
        bool isset_exec_duration_in_us = false;
        bool isset_total_duration_in_us = false;
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
                Rows = await iprot.ReadI64Async(cancellationToken);
                isset_rows = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                Exec_duration_in_us = await iprot.ReadI64Async(cancellationToken);
                isset_exec_duration_in_us = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Total_duration_in_us = await iprot.ReadI64Async(cancellationToken);
                isset_total_duration_in_us = true;
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
                  TMap _map1 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Other_stats = new Dictionary<byte[], byte[]>(_map1.Count);
                  for(int _i2 = 0; _i2 < _map1.Count; ++_i2)
                  {
                    byte[] _key3;
                    byte[] _val4;
                    _key3 = await iprot.ReadBinaryAsync(cancellationToken);
                    _val4 = await iprot.ReadBinaryAsync(cancellationToken);
                    Other_stats[_key3] = _val4;
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
        if (!isset_rows)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_exec_duration_in_us)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_total_duration_in_us)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
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
        var tmp5 = new TStruct("ProfilingStats");
        await oprot.WriteStructBeginAsync(tmp5, cancellationToken);
        var tmp6 = new TField();
        tmp6.Name = "rows";
        tmp6.Type = TType.I64;
        tmp6.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp6, cancellationToken);
        await oprot.WriteI64Async(Rows, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        tmp6.Name = "exec_duration_in_us";
        tmp6.Type = TType.I64;
        tmp6.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp6, cancellationToken);
        await oprot.WriteI64Async(Exec_duration_in_us, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        tmp6.Name = "total_duration_in_us";
        tmp6.Type = TType.I64;
        tmp6.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp6, cancellationToken);
        await oprot.WriteI64Async(Total_duration_in_us, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((Other_stats != null) && __isset.other_stats)
        {
          tmp6.Name = "other_stats";
          tmp6.Type = TType.Map;
          tmp6.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp6, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, Other_stats.Count), cancellationToken);
            foreach (byte[] _iter7 in Other_stats.Keys)
            {
              await oprot.WriteBinaryAsync(_iter7, cancellationToken);
              await oprot.WriteBinaryAsync(Other_stats[_iter7], cancellationToken);
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
      if (!(that is ProfilingStats other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Rows, other.Rows)
        && System.Object.Equals(Exec_duration_in_us, other.Exec_duration_in_us)
        && System.Object.Equals(Total_duration_in_us, other.Total_duration_in_us)
        && ((__isset.other_stats == other.__isset.other_stats) && ((!__isset.other_stats) || (TCollections.Equals(Other_stats, other.Other_stats))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Rows.GetHashCode();
        hashcode = (hashcode * 397) + Exec_duration_in_us.GetHashCode();
        hashcode = (hashcode * 397) + Total_duration_in_us.GetHashCode();
        if((Other_stats != null) && __isset.other_stats)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Other_stats);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp8 = new StringBuilder("ProfilingStats(");
      tmp8.Append(", Rows: ");
      Rows.ToString(tmp8);
      tmp8.Append(", Exec_duration_in_us: ");
      Exec_duration_in_us.ToString(tmp8);
      tmp8.Append(", Total_duration_in_us: ");
      Total_duration_in_us.ToString(tmp8);
      if((Other_stats != null) && __isset.other_stats)
      {
        tmp8.Append(", Other_stats: ");
        Other_stats.ToString(tmp8);
      }
      tmp8.Append(')');
      return tmp8.ToString();
    }
  }

}