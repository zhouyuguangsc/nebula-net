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

  public partial class CreateTagReq : TBase
  {
    private int _space_id;
    private byte[] _tag_name;
    private global::Nebula.Meta.Schema _schema;
    private bool _if_not_exists;

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

    public byte[] Tag_name
    {
      get
      {
        return _tag_name;
      }
      set
      {
        __isset.tag_name = true;
        this._tag_name = value;
      }
    }

    public global::Nebula.Meta.Schema Schema
    {
      get
      {
        return _schema;
      }
      set
      {
        __isset.schema = true;
        this._schema = value;
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


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool tag_name;
      public bool schema;
      public bool if_not_exists;
    }

    public CreateTagReq()
    {
    }

    public CreateTagReq DeepCopy()
    {
      var tmp223 = new CreateTagReq();
      if(__isset.space_id)
      {
        tmp223.Space_id = this.Space_id;
      }
      tmp223.__isset.space_id = this.__isset.space_id;
      if((Tag_name != null) && __isset.tag_name)
      {
        tmp223.Tag_name = this.Tag_name.ToArray();
      }
      tmp223.__isset.tag_name = this.__isset.tag_name;
      if((Schema != null) && __isset.schema)
      {
        tmp223.Schema = (global::Nebula.Meta.Schema)this.Schema.DeepCopy();
      }
      tmp223.__isset.schema = this.__isset.schema;
      if(__isset.if_not_exists)
      {
        tmp223.If_not_exists = this.If_not_exists;
      }
      tmp223.__isset.if_not_exists = this.__isset.if_not_exists;
      return tmp223;
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
              if (field.Type == TType.String)
              {
                Tag_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                Schema = new global::Nebula.Meta.Schema();
                await Schema.ReadAsync(iprot, cancellationToken);
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
        var tmp224 = new TStruct("CreateTagReq");
        await oprot.WriteStructBeginAsync(tmp224, cancellationToken);
        var tmp225 = new TField();
        if(__isset.space_id)
        {
          tmp225.Name = "space_id";
          tmp225.Type = TType.I32;
          tmp225.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp225, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Tag_name != null) && __isset.tag_name)
        {
          tmp225.Name = "tag_name";
          tmp225.Type = TType.String;
          tmp225.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp225, cancellationToken);
          await oprot.WriteBinaryAsync(Tag_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Schema != null) && __isset.schema)
        {
          tmp225.Name = "schema";
          tmp225.Type = TType.Struct;
          tmp225.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp225, cancellationToken);
          await Schema.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.if_not_exists)
        {
          tmp225.Name = "if_not_exists";
          tmp225.Type = TType.Bool;
          tmp225.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp225, cancellationToken);
          await oprot.WriteBoolAsync(If_not_exists, cancellationToken);
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
      if (!(that is CreateTagReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.tag_name == other.__isset.tag_name) && ((!__isset.tag_name) || (TCollections.Equals(Tag_name, other.Tag_name))))
        && ((__isset.schema == other.__isset.schema) && ((!__isset.schema) || (System.Object.Equals(Schema, other.Schema))))
        && ((__isset.if_not_exists == other.__isset.if_not_exists) && ((!__isset.if_not_exists) || (System.Object.Equals(If_not_exists, other.If_not_exists))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if((Tag_name != null) && __isset.tag_name)
        {
          hashcode = (hashcode * 397) + Tag_name.GetHashCode();
        }
        if((Schema != null) && __isset.schema)
        {
          hashcode = (hashcode * 397) + Schema.GetHashCode();
        }
        if(__isset.if_not_exists)
        {
          hashcode = (hashcode * 397) + If_not_exists.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp226 = new StringBuilder("CreateTagReq(");
      int tmp227 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp227++) { tmp226.Append(", "); }
        tmp226.Append("Space_id: ");
        Space_id.ToString(tmp226);
      }
      if((Tag_name != null) && __isset.tag_name)
      {
        if(0 < tmp227++) { tmp226.Append(", "); }
        tmp226.Append("Tag_name: ");
        Tag_name.ToString(tmp226);
      }
      if((Schema != null) && __isset.schema)
      {
        if(0 < tmp227++) { tmp226.Append(", "); }
        tmp226.Append("Schema: ");
        Schema.ToString(tmp226);
      }
      if(__isset.if_not_exists)
      {
        if(0 < tmp227++) { tmp226.Append(", "); }
        tmp226.Append("If_not_exists: ");
        If_not_exists.ToString(tmp226);
      }
      tmp226.Append(')');
      return tmp226.ToString();
    }
  }

}
