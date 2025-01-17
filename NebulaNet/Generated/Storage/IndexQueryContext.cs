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

  public partial class IndexQueryContext : TBase
  {
    private int _index_id;
    private byte[] _filter;
    private List<global::Nebula.Storage.IndexColumnHint> _column_hints;

    public int Index_id
    {
      get
      {
        return _index_id;
      }
      set
      {
        __isset.index_id = true;
        this._index_id = value;
      }
    }

    public byte[] Filter
    {
      get
      {
        return _filter;
      }
      set
      {
        __isset.filter = true;
        this._filter = value;
      }
    }

    public List<global::Nebula.Storage.IndexColumnHint> Column_hints
    {
      get
      {
        return _column_hints;
      }
      set
      {
        __isset.column_hints = true;
        this._column_hints = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool index_id;
      public bool filter;
      public bool column_hints;
    }

    public IndexQueryContext()
    {
    }

    public IndexQueryContext DeepCopy()
    {
      var tmp329 = new IndexQueryContext();
      if(__isset.index_id)
      {
        tmp329.Index_id = this.Index_id;
      }
      tmp329.__isset.index_id = this.__isset.index_id;
      if((Filter != null) && __isset.filter)
      {
        tmp329.Filter = this.Filter.ToArray();
      }
      tmp329.__isset.filter = this.__isset.filter;
      if((Column_hints != null) && __isset.column_hints)
      {
        tmp329.Column_hints = this.Column_hints.DeepCopy();
      }
      tmp329.__isset.column_hints = this.__isset.column_hints;
      return tmp329;
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
                Index_id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Filter = await iprot.ReadBinaryAsync(cancellationToken);
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
                  TList _list330 = await iprot.ReadListBeginAsync(cancellationToken);
                  Column_hints = new List<global::Nebula.Storage.IndexColumnHint>(_list330.Count);
                  for(int _i331 = 0; _i331 < _list330.Count; ++_i331)
                  {
                    global::Nebula.Storage.IndexColumnHint _elem332;
                    _elem332 = new global::Nebula.Storage.IndexColumnHint();
                    await _elem332.ReadAsync(iprot, cancellationToken);
                    Column_hints.Add(_elem332);
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
        var tmp333 = new TStruct("IndexQueryContext");
        await oprot.WriteStructBeginAsync(tmp333, cancellationToken);
        var tmp334 = new TField();
        if(__isset.index_id)
        {
          tmp334.Name = "index_id";
          tmp334.Type = TType.I32;
          tmp334.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp334, cancellationToken);
          await oprot.WriteI32Async(Index_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Filter != null) && __isset.filter)
        {
          tmp334.Name = "filter";
          tmp334.Type = TType.String;
          tmp334.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp334, cancellationToken);
          await oprot.WriteBinaryAsync(Filter, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Column_hints != null) && __isset.column_hints)
        {
          tmp334.Name = "column_hints";
          tmp334.Type = TType.List;
          tmp334.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp334, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Column_hints.Count), cancellationToken);
            foreach (global::Nebula.Storage.IndexColumnHint _iter335 in Column_hints)
            {
              await _iter335.WriteAsync(oprot, cancellationToken);
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
      if (!(that is IndexQueryContext other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.index_id == other.__isset.index_id) && ((!__isset.index_id) || (System.Object.Equals(Index_id, other.Index_id))))
        && ((__isset.filter == other.__isset.filter) && ((!__isset.filter) || (TCollections.Equals(Filter, other.Filter))))
        && ((__isset.column_hints == other.__isset.column_hints) && ((!__isset.column_hints) || (TCollections.Equals(Column_hints, other.Column_hints))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.index_id)
        {
          hashcode = (hashcode * 397) + Index_id.GetHashCode();
        }
        if((Filter != null) && __isset.filter)
        {
          hashcode = (hashcode * 397) + Filter.GetHashCode();
        }
        if((Column_hints != null) && __isset.column_hints)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Column_hints);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp336 = new StringBuilder("IndexQueryContext(");
      int tmp337 = 0;
      if(__isset.index_id)
      {
        if(0 < tmp337++) { tmp336.Append(", "); }
        tmp336.Append("Index_id: ");
        Index_id.ToString(tmp336);
      }
      if((Filter != null) && __isset.filter)
      {
        if(0 < tmp337++) { tmp336.Append(", "); }
        tmp336.Append("Filter: ");
        Filter.ToString(tmp336);
      }
      if((Column_hints != null) && __isset.column_hints)
      {
        if(0 < tmp337++) { tmp336.Append(", "); }
        tmp336.Append("Column_hints: ");
        Column_hints.ToString(tmp336);
      }
      tmp336.Append(')');
      return tmp336.ToString();
    }
  }

}
