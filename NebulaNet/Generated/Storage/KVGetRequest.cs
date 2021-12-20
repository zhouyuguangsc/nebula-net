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

  public partial class KVGetRequest : TBase
  {
    private int _space_id;
    private Dictionary<int, List<byte[]>> _parts;
    private bool _return_partly;

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

    public Dictionary<int, List<byte[]>> Parts
    {
      get
      {
        return _parts;
      }
      set
      {
        __isset.parts = true;
        this._parts = value;
      }
    }

    public bool Return_partly
    {
      get
      {
        return _return_partly;
      }
      set
      {
        __isset.return_partly = true;
        this._return_partly = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool parts;
      public bool return_partly;
    }

    public KVGetRequest()
    {
    }

    public KVGetRequest DeepCopy()
    {
      var tmp520 = new KVGetRequest();
      if(__isset.space_id)
      {
        tmp520.Space_id = this.Space_id;
      }
      tmp520.__isset.space_id = this.__isset.space_id;
      if((Parts != null) && __isset.parts)
      {
        tmp520.Parts = this.Parts.DeepCopy();
      }
      tmp520.__isset.parts = this.__isset.parts;
      if(__isset.return_partly)
      {
        tmp520.Return_partly = this.Return_partly;
      }
      tmp520.__isset.return_partly = this.__isset.return_partly;
      return tmp520;
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
              if (field.Type == TType.Map)
              {
                {
                  TMap _map521 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Parts = new Dictionary<int, List<byte[]>>(_map521.Count);
                  for(int _i522 = 0; _i522 < _map521.Count; ++_i522)
                  {
                    int _key523;
                    List<byte[]> _val524;
                    _key523 = await iprot.ReadI32Async(cancellationToken);
                    {
                      TList _list525 = await iprot.ReadListBeginAsync(cancellationToken);
                      _val524 = new List<byte[]>(_list525.Count);
                      for(int _i526 = 0; _i526 < _list525.Count; ++_i526)
                      {
                        byte[] _elem527;
                        _elem527 = await iprot.ReadBinaryAsync(cancellationToken);
                        _val524.Add(_elem527);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    Parts[_key523] = _val524;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Bool)
              {
                Return_partly = await iprot.ReadBoolAsync(cancellationToken);
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
        var tmp528 = new TStruct("KVGetRequest");
        await oprot.WriteStructBeginAsync(tmp528, cancellationToken);
        var tmp529 = new TField();
        if(__isset.space_id)
        {
          tmp529.Name = "space_id";
          tmp529.Type = TType.I32;
          tmp529.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp529, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Parts != null) && __isset.parts)
        {
          tmp529.Name = "parts";
          tmp529.Type = TType.Map;
          tmp529.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp529, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.I32, TType.List, Parts.Count), cancellationToken);
            foreach (int _iter530 in Parts.Keys)
            {
              await oprot.WriteI32Async(_iter530, cancellationToken);
              {
                await oprot.WriteListBeginAsync(new TList(TType.String, Parts[_iter530].Count), cancellationToken);
                foreach (byte[] _iter531 in Parts[_iter530])
                {
                  await oprot.WriteBinaryAsync(_iter531, cancellationToken);
                }
                await oprot.WriteListEndAsync(cancellationToken);
              }
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.return_partly)
        {
          tmp529.Name = "return_partly";
          tmp529.Type = TType.Bool;
          tmp529.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp529, cancellationToken);
          await oprot.WriteBoolAsync(Return_partly, cancellationToken);
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
      if (!(that is KVGetRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.parts == other.__isset.parts) && ((!__isset.parts) || (TCollections.Equals(Parts, other.Parts))))
        && ((__isset.return_partly == other.__isset.return_partly) && ((!__isset.return_partly) || (System.Object.Equals(Return_partly, other.Return_partly))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if((Parts != null) && __isset.parts)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Parts);
        }
        if(__isset.return_partly)
        {
          hashcode = (hashcode * 397) + Return_partly.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp532 = new StringBuilder("KVGetRequest(");
      int tmp533 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp533++) { tmp532.Append(", "); }
        tmp532.Append("Space_id: ");
        Space_id.ToString(tmp532);
      }
      if((Parts != null) && __isset.parts)
      {
        if(0 < tmp533++) { tmp532.Append(", "); }
        tmp532.Append("Parts: ");
        Parts.ToString(tmp532);
      }
      if(__isset.return_partly)
      {
        if(0 < tmp533++) { tmp532.Append(", "); }
        tmp532.Append("Return_partly: ");
        Return_partly.ToString(tmp532);
      }
      tmp532.Append(')');
      return tmp532.ToString();
    }
  }

}