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

  public partial class GetTagReq : TBase
  {
    private int _space_id;
    private byte[] _tag_name;
    private long _version;

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

    public long Version
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
      public bool space_id;
      public bool tag_name;
      public bool version;
    }

    public GetTagReq()
    {
    }

    public GetTagReq DeepCopy()
    {
      var tmp256 = new GetTagReq();
      if(__isset.space_id)
      {
        tmp256.Space_id = this.Space_id;
      }
      tmp256.__isset.space_id = this.__isset.space_id;
      if((Tag_name != null) && __isset.tag_name)
      {
        tmp256.Tag_name = this.Tag_name.ToArray();
      }
      tmp256.__isset.tag_name = this.__isset.tag_name;
      if(__isset.version)
      {
        tmp256.Version = this.Version;
      }
      tmp256.__isset.version = this.__isset.version;
      return tmp256;
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
              if (field.Type == TType.I64)
              {
                Version = await iprot.ReadI64Async(cancellationToken);
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
        var tmp257 = new TStruct("GetTagReq");
        await oprot.WriteStructBeginAsync(tmp257, cancellationToken);
        var tmp258 = new TField();
        if(__isset.space_id)
        {
          tmp258.Name = "space_id";
          tmp258.Type = TType.I32;
          tmp258.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp258, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Tag_name != null) && __isset.tag_name)
        {
          tmp258.Name = "tag_name";
          tmp258.Type = TType.String;
          tmp258.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp258, cancellationToken);
          await oprot.WriteBinaryAsync(Tag_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.version)
        {
          tmp258.Name = "version";
          tmp258.Type = TType.I64;
          tmp258.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp258, cancellationToken);
          await oprot.WriteI64Async(Version, cancellationToken);
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
      if (!(that is GetTagReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.tag_name == other.__isset.tag_name) && ((!__isset.tag_name) || (TCollections.Equals(Tag_name, other.Tag_name))))
        && ((__isset.version == other.__isset.version) && ((!__isset.version) || (System.Object.Equals(Version, other.Version))));
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
        if(__isset.version)
        {
          hashcode = (hashcode * 397) + Version.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp259 = new StringBuilder("GetTagReq(");
      int tmp260 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp260++) { tmp259.Append(", "); }
        tmp259.Append("Space_id: ");
        Space_id.ToString(tmp259);
      }
      if((Tag_name != null) && __isset.tag_name)
      {
        if(0 < tmp260++) { tmp259.Append(", "); }
        tmp259.Append("Tag_name: ");
        Tag_name.ToString(tmp259);
      }
      if(__isset.version)
      {
        if(0 < tmp260++) { tmp259.Append(", "); }
        tmp259.Append("Version: ");
        Version.ToString(tmp259);
      }
      tmp259.Append(')');
      return tmp259.ToString();
    }
  }

}