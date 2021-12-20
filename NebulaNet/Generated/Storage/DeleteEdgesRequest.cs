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

  public partial class DeleteEdgesRequest : TBase
  {
    private int _space_id;
    private Dictionary<int, List<global::Nebula.Storage.EdgeKey>> _parts;
    private global::Nebula.Storage.RequestCommon _common;

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

    public Dictionary<int, List<global::Nebula.Storage.EdgeKey>> Parts
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

    public global::Nebula.Storage.RequestCommon Common
    {
      get
      {
        return _common;
      }
      set
      {
        __isset.common = true;
        this._common = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool parts;
      public bool common;
    }

    public DeleteEdgesRequest()
    {
    }

    public DeleteEdgesRequest DeepCopy()
    {
      var tmp236 = new DeleteEdgesRequest();
      if(__isset.space_id)
      {
        tmp236.Space_id = this.Space_id;
      }
      tmp236.__isset.space_id = this.__isset.space_id;
      if((Parts != null) && __isset.parts)
      {
        tmp236.Parts = this.Parts.DeepCopy();
      }
      tmp236.__isset.parts = this.__isset.parts;
      if((Common != null) && __isset.common)
      {
        tmp236.Common = (global::Nebula.Storage.RequestCommon)this.Common.DeepCopy();
      }
      tmp236.__isset.common = this.__isset.common;
      return tmp236;
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
                  TMap _map237 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Parts = new Dictionary<int, List<global::Nebula.Storage.EdgeKey>>(_map237.Count);
                  for(int _i238 = 0; _i238 < _map237.Count; ++_i238)
                  {
                    int _key239;
                    List<global::Nebula.Storage.EdgeKey> _val240;
                    _key239 = await iprot.ReadI32Async(cancellationToken);
                    {
                      TList _list241 = await iprot.ReadListBeginAsync(cancellationToken);
                      _val240 = new List<global::Nebula.Storage.EdgeKey>(_list241.Count);
                      for(int _i242 = 0; _i242 < _list241.Count; ++_i242)
                      {
                        global::Nebula.Storage.EdgeKey _elem243;
                        _elem243 = new global::Nebula.Storage.EdgeKey();
                        await _elem243.ReadAsync(iprot, cancellationToken);
                        _val240.Add(_elem243);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    Parts[_key239] = _val240;
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
              if (field.Type == TType.Struct)
              {
                Common = new global::Nebula.Storage.RequestCommon();
                await Common.ReadAsync(iprot, cancellationToken);
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
        var tmp244 = new TStruct("DeleteEdgesRequest");
        await oprot.WriteStructBeginAsync(tmp244, cancellationToken);
        var tmp245 = new TField();
        if(__isset.space_id)
        {
          tmp245.Name = "space_id";
          tmp245.Type = TType.I32;
          tmp245.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp245, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Parts != null) && __isset.parts)
        {
          tmp245.Name = "parts";
          tmp245.Type = TType.Map;
          tmp245.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp245, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.I32, TType.List, Parts.Count), cancellationToken);
            foreach (int _iter246 in Parts.Keys)
            {
              await oprot.WriteI32Async(_iter246, cancellationToken);
              {
                await oprot.WriteListBeginAsync(new TList(TType.Struct, Parts[_iter246].Count), cancellationToken);
                foreach (global::Nebula.Storage.EdgeKey _iter247 in Parts[_iter246])
                {
                  await _iter247.WriteAsync(oprot, cancellationToken);
                }
                await oprot.WriteListEndAsync(cancellationToken);
              }
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Common != null) && __isset.common)
        {
          tmp245.Name = "common";
          tmp245.Type = TType.Struct;
          tmp245.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp245, cancellationToken);
          await Common.WriteAsync(oprot, cancellationToken);
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
      if (!(that is DeleteEdgesRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.parts == other.__isset.parts) && ((!__isset.parts) || (TCollections.Equals(Parts, other.Parts))))
        && ((__isset.common == other.__isset.common) && ((!__isset.common) || (System.Object.Equals(Common, other.Common))));
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
        if((Common != null) && __isset.common)
        {
          hashcode = (hashcode * 397) + Common.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp248 = new StringBuilder("DeleteEdgesRequest(");
      int tmp249 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp249++) { tmp248.Append(", "); }
        tmp248.Append("Space_id: ");
        Space_id.ToString(tmp248);
      }
      if((Parts != null) && __isset.parts)
      {
        if(0 < tmp249++) { tmp248.Append(", "); }
        tmp248.Append("Parts: ");
        Parts.ToString(tmp248);
      }
      if((Common != null) && __isset.common)
      {
        if(0 < tmp249++) { tmp248.Append(", "); }
        tmp248.Append("Common: ");
        Common.ToString(tmp248);
      }
      tmp248.Append(')');
      return tmp248.ToString();
    }
  }

}