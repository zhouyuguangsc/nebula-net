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

  public partial class ChainAddEdgesRequest : TBase
  {
    private int _space_id;
    private Dictionary<int, List<global::Nebula.Storage.NewEdge>> _parts;
    private List<byte[]> _prop_names;
    private bool _if_not_exists;
    private long _term;
    private long _edge_version;

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

    public Dictionary<int, List<global::Nebula.Storage.NewEdge>> Parts
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

    public List<byte[]> Prop_names
    {
      get
      {
        return _prop_names;
      }
      set
      {
        __isset.prop_names = true;
        this._prop_names = value;
      }
    }

    public bool If_not_exists
    {
      get
      {
        return _if_not_exists;
      }
      set
      {
        __isset.if_not_exists = true;
        this._if_not_exists = value;
      }
    }

    public long Term
    {
      get
      {
        return _term;
      }
      set
      {
        __isset.term = true;
        this._term = value;
      }
    }

    public long Edge_version
    {
      get
      {
        return _edge_version;
      }
      set
      {
        __isset.edge_version = true;
        this._edge_version = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool parts;
      public bool prop_names;
      public bool if_not_exists;
      public bool term;
      public bool edge_version;
    }

    public ChainAddEdgesRequest()
    {
    }

    public ChainAddEdgesRequest DeepCopy()
    {
      var tmp591 = new ChainAddEdgesRequest();
      if(__isset.space_id)
      {
        tmp591.Space_id = this.Space_id;
      }
      tmp591.__isset.space_id = this.__isset.space_id;
      if((Parts != null) && __isset.parts)
      {
        tmp591.Parts = this.Parts.DeepCopy();
      }
      tmp591.__isset.parts = this.__isset.parts;
      if((Prop_names != null) && __isset.prop_names)
      {
        tmp591.Prop_names = this.Prop_names.DeepCopy();
      }
      tmp591.__isset.prop_names = this.__isset.prop_names;
      if(__isset.if_not_exists)
      {
        tmp591.If_not_exists = this.If_not_exists;
      }
      tmp591.__isset.if_not_exists = this.__isset.if_not_exists;
      if(__isset.term)
      {
        tmp591.Term = this.Term;
      }
      tmp591.__isset.term = this.__isset.term;
      if(__isset.edge_version)
      {
        tmp591.Edge_version = this.Edge_version;
      }
      tmp591.__isset.edge_version = this.__isset.edge_version;
      return tmp591;
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
                  TMap _map592 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Parts = new Dictionary<int, List<global::Nebula.Storage.NewEdge>>(_map592.Count);
                  for(int _i593 = 0; _i593 < _map592.Count; ++_i593)
                  {
                    int _key594;
                    List<global::Nebula.Storage.NewEdge> _val595;
                    _key594 = await iprot.ReadI32Async(cancellationToken);
                    {
                      TList _list596 = await iprot.ReadListBeginAsync(cancellationToken);
                      _val595 = new List<global::Nebula.Storage.NewEdge>(_list596.Count);
                      for(int _i597 = 0; _i597 < _list596.Count; ++_i597)
                      {
                        global::Nebula.Storage.NewEdge _elem598;
                        _elem598 = new global::Nebula.Storage.NewEdge();
                        await _elem598.ReadAsync(iprot, cancellationToken);
                        _val595.Add(_elem598);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    Parts[_key594] = _val595;
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
              if (field.Type == TType.List)
              {
                {
                  TList _list599 = await iprot.ReadListBeginAsync(cancellationToken);
                  Prop_names = new List<byte[]>(_list599.Count);
                  for(int _i600 = 0; _i600 < _list599.Count; ++_i600)
                  {
                    byte[] _elem601;
                    _elem601 = await iprot.ReadBinaryAsync(cancellationToken);
                    Prop_names.Add(_elem601);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Bool)
              {
                If_not_exists = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I64)
              {
                Term = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.I64)
              {
                Edge_version = await iprot.ReadI64Async(cancellationToken);
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
        var tmp602 = new TStruct("ChainAddEdgesRequest");
        await oprot.WriteStructBeginAsync(tmp602, cancellationToken);
        var tmp603 = new TField();
        if(__isset.space_id)
        {
          tmp603.Name = "space_id";
          tmp603.Type = TType.I32;
          tmp603.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp603, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Parts != null) && __isset.parts)
        {
          tmp603.Name = "parts";
          tmp603.Type = TType.Map;
          tmp603.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp603, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.I32, TType.List, Parts.Count), cancellationToken);
            foreach (int _iter604 in Parts.Keys)
            {
              await oprot.WriteI32Async(_iter604, cancellationToken);
              {
                await oprot.WriteListBeginAsync(new TList(TType.Struct, Parts[_iter604].Count), cancellationToken);
                foreach (global::Nebula.Storage.NewEdge _iter605 in Parts[_iter604])
                {
                  await _iter605.WriteAsync(oprot, cancellationToken);
                }
                await oprot.WriteListEndAsync(cancellationToken);
              }
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Prop_names != null) && __isset.prop_names)
        {
          tmp603.Name = "prop_names";
          tmp603.Type = TType.List;
          tmp603.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp603, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, Prop_names.Count), cancellationToken);
            foreach (byte[] _iter606 in Prop_names)
            {
              await oprot.WriteBinaryAsync(_iter606, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.if_not_exists)
        {
          tmp603.Name = "if_not_exists";
          tmp603.Type = TType.Bool;
          tmp603.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp603, cancellationToken);
          await oprot.WriteBoolAsync(If_not_exists, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.term)
        {
          tmp603.Name = "term";
          tmp603.Type = TType.I64;
          tmp603.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp603, cancellationToken);
          await oprot.WriteI64Async(Term, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.edge_version)
        {
          tmp603.Name = "edge_version";
          tmp603.Type = TType.I64;
          tmp603.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp603, cancellationToken);
          await oprot.WriteI64Async(Edge_version, cancellationToken);
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
      if (!(that is ChainAddEdgesRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.parts == other.__isset.parts) && ((!__isset.parts) || (TCollections.Equals(Parts, other.Parts))))
        && ((__isset.prop_names == other.__isset.prop_names) && ((!__isset.prop_names) || (TCollections.Equals(Prop_names, other.Prop_names))))
        && ((__isset.if_not_exists == other.__isset.if_not_exists) && ((!__isset.if_not_exists) || (System.Object.Equals(If_not_exists, other.If_not_exists))))
        && ((__isset.term == other.__isset.term) && ((!__isset.term) || (System.Object.Equals(Term, other.Term))))
        && ((__isset.edge_version == other.__isset.edge_version) && ((!__isset.edge_version) || (System.Object.Equals(Edge_version, other.Edge_version))));
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
        if((Prop_names != null) && __isset.prop_names)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Prop_names);
        }
        if(__isset.if_not_exists)
        {
          hashcode = (hashcode * 397) + If_not_exists.GetHashCode();
        }
        if(__isset.term)
        {
          hashcode = (hashcode * 397) + Term.GetHashCode();
        }
        if(__isset.edge_version)
        {
          hashcode = (hashcode * 397) + Edge_version.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp607 = new StringBuilder("ChainAddEdgesRequest(");
      int tmp608 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp608++) { tmp607.Append(", "); }
        tmp607.Append("Space_id: ");
        Space_id.ToString(tmp607);
      }
      if((Parts != null) && __isset.parts)
      {
        if(0 < tmp608++) { tmp607.Append(", "); }
        tmp607.Append("Parts: ");
        Parts.ToString(tmp607);
      }
      if((Prop_names != null) && __isset.prop_names)
      {
        if(0 < tmp608++) { tmp607.Append(", "); }
        tmp607.Append("Prop_names: ");
        Prop_names.ToString(tmp607);
      }
      if(__isset.if_not_exists)
      {
        if(0 < tmp608++) { tmp607.Append(", "); }
        tmp607.Append("If_not_exists: ");
        If_not_exists.ToString(tmp607);
      }
      if(__isset.term)
      {
        if(0 < tmp608++) { tmp607.Append(", "); }
        tmp607.Append("Term: ");
        Term.ToString(tmp607);
      }
      if(__isset.edge_version)
      {
        if(0 < tmp608++) { tmp607.Append(", "); }
        tmp607.Append("Edge_version: ");
        Edge_version.ToString(tmp607);
      }
      tmp607.Append(')');
      return tmp607.ToString();
    }
  }

}