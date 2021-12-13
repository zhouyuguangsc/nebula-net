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

  public partial class AddVerticesRequest : TBase
  {
    private int _space_id;
    private Dictionary<int, List<global::Nebula.Storage.NewVertex>> _parts;
    private Dictionary<int, List<byte[]>> _prop_names;
    private bool _if_not_exists;
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

    public Dictionary<int, List<global::Nebula.Storage.NewVertex>> Parts
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

    public Dictionary<int, List<byte[]>> Prop_names
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
      public bool prop_names;
      public bool if_not_exists;
      public bool common;
    }

    public AddVerticesRequest()
    {
    }

    public AddVerticesRequest DeepCopy()
    {
      var tmp181 = new AddVerticesRequest();
      if(__isset.space_id)
      {
        tmp181.Space_id = this.Space_id;
      }
      tmp181.__isset.space_id = this.__isset.space_id;
      if((Parts != null) && __isset.parts)
      {
        tmp181.Parts = this.Parts.DeepCopy();
      }
      tmp181.__isset.parts = this.__isset.parts;
      if((Prop_names != null) && __isset.prop_names)
      {
        tmp181.Prop_names = this.Prop_names.DeepCopy();
      }
      tmp181.__isset.prop_names = this.__isset.prop_names;
      if(__isset.if_not_exists)
      {
        tmp181.If_not_exists = this.If_not_exists;
      }
      tmp181.__isset.if_not_exists = this.__isset.if_not_exists;
      if((Common != null) && __isset.common)
      {
        tmp181.Common = (global::Nebula.Storage.RequestCommon)this.Common.DeepCopy();
      }
      tmp181.__isset.common = this.__isset.common;
      return tmp181;
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
                  TMap _map182 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Parts = new Dictionary<int, List<global::Nebula.Storage.NewVertex>>(_map182.Count);
                  for(int _i183 = 0; _i183 < _map182.Count; ++_i183)
                  {
                    int _key184;
                    List<global::Nebula.Storage.NewVertex> _val185;
                    _key184 = await iprot.ReadI32Async(cancellationToken);
                    {
                      TList _list186 = await iprot.ReadListBeginAsync(cancellationToken);
                      _val185 = new List<global::Nebula.Storage.NewVertex>(_list186.Count);
                      for(int _i187 = 0; _i187 < _list186.Count; ++_i187)
                      {
                        global::Nebula.Storage.NewVertex _elem188;
                        _elem188 = new global::Nebula.Storage.NewVertex();
                        await _elem188.ReadAsync(iprot, cancellationToken);
                        _val185.Add(_elem188);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    Parts[_key184] = _val185;
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
              if (field.Type == TType.Map)
              {
                {
                  TMap _map189 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Prop_names = new Dictionary<int, List<byte[]>>(_map189.Count);
                  for(int _i190 = 0; _i190 < _map189.Count; ++_i190)
                  {
                    int _key191;
                    List<byte[]> _val192;
                    _key191 = await iprot.ReadI32Async(cancellationToken);
                    {
                      TList _list193 = await iprot.ReadListBeginAsync(cancellationToken);
                      _val192 = new List<byte[]>(_list193.Count);
                      for(int _i194 = 0; _i194 < _list193.Count; ++_i194)
                      {
                        byte[] _elem195;
                        _elem195 = await iprot.ReadBinaryAsync(cancellationToken);
                        _val192.Add(_elem195);
                      }
                      await iprot.ReadListEndAsync(cancellationToken);
                    }
                    Prop_names[_key191] = _val192;
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
        var tmp196 = new TStruct("AddVerticesRequest");
        await oprot.WriteStructBeginAsync(tmp196, cancellationToken);
        var tmp197 = new TField();
        if(__isset.space_id)
        {
          tmp197.Name = "space_id";
          tmp197.Type = TType.I32;
          tmp197.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp197, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Parts != null) && __isset.parts)
        {
          tmp197.Name = "parts";
          tmp197.Type = TType.Map;
          tmp197.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp197, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.I32, TType.List, Parts.Count), cancellationToken);
            foreach (int _iter198 in Parts.Keys)
            {
              await oprot.WriteI32Async(_iter198, cancellationToken);
              {
                await oprot.WriteListBeginAsync(new TList(TType.Struct, Parts[_iter198].Count), cancellationToken);
                foreach (global::Nebula.Storage.NewVertex _iter199 in Parts[_iter198])
                {
                  await _iter199.WriteAsync(oprot, cancellationToken);
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
          tmp197.Name = "prop_names";
          tmp197.Type = TType.Map;
          tmp197.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp197, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.I32, TType.List, Prop_names.Count), cancellationToken);
            foreach (int _iter200 in Prop_names.Keys)
            {
              await oprot.WriteI32Async(_iter200, cancellationToken);
              {
                await oprot.WriteListBeginAsync(new TList(TType.String, Prop_names[_iter200].Count), cancellationToken);
                foreach (byte[] _iter201 in Prop_names[_iter200])
                {
                  await oprot.WriteBinaryAsync(_iter201, cancellationToken);
                }
                await oprot.WriteListEndAsync(cancellationToken);
              }
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.if_not_exists)
        {
          tmp197.Name = "if_not_exists";
          tmp197.Type = TType.Bool;
          tmp197.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp197, cancellationToken);
          await oprot.WriteBoolAsync(If_not_exists, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Common != null) && __isset.common)
        {
          tmp197.Name = "common";
          tmp197.Type = TType.Struct;
          tmp197.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp197, cancellationToken);
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
      if (!(that is AddVerticesRequest other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.parts == other.__isset.parts) && ((!__isset.parts) || (TCollections.Equals(Parts, other.Parts))))
        && ((__isset.prop_names == other.__isset.prop_names) && ((!__isset.prop_names) || (TCollections.Equals(Prop_names, other.Prop_names))))
        && ((__isset.if_not_exists == other.__isset.if_not_exists) && ((!__isset.if_not_exists) || (System.Object.Equals(If_not_exists, other.If_not_exists))))
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
        if((Prop_names != null) && __isset.prop_names)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Prop_names);
        }
        if(__isset.if_not_exists)
        {
          hashcode = (hashcode * 397) + If_not_exists.GetHashCode();
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
      var tmp202 = new StringBuilder("AddVerticesRequest(");
      int tmp203 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp203++) { tmp202.Append(", "); }
        tmp202.Append("Space_id: ");
        Space_id.ToString(tmp202);
      }
      if((Parts != null) && __isset.parts)
      {
        if(0 < tmp203++) { tmp202.Append(", "); }
        tmp202.Append("Parts: ");
        Parts.ToString(tmp202);
      }
      if((Prop_names != null) && __isset.prop_names)
      {
        if(0 < tmp203++) { tmp202.Append(", "); }
        tmp202.Append("Prop_names: ");
        Prop_names.ToString(tmp202);
      }
      if(__isset.if_not_exists)
      {
        if(0 < tmp203++) { tmp202.Append(", "); }
        tmp202.Append("If_not_exists: ");
        If_not_exists.ToString(tmp202);
      }
      if((Common != null) && __isset.common)
      {
        if(0 < tmp203++) { tmp202.Append(", "); }
        tmp202.Append("Common: ");
        Common.ToString(tmp202);
      }
      tmp202.Append(')');
      return tmp202.ToString();
    }
  }

}
