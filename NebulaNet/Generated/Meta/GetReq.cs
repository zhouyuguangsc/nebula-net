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

  public partial class GetReq : TBase
  {
    private byte[] _segment;
    private byte[] _key;

    public byte[] Segment
    {
      get
      {
        return _segment;
      }
      set
      {
        __isset.segment = true;
        this._segment = value;
      }
    }

    public byte[] Key
    {
      get
      {
        return _key;
      }
      set
      {
        __isset.key = true;
        this._key = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool segment;
      public bool key;
    }

    public GetReq()
    {
    }

    public GetReq DeepCopy()
    {
      var tmp387 = new GetReq();
      if((Segment != null) && __isset.segment)
      {
        tmp387.Segment = this.Segment.ToArray();
      }
      tmp387.__isset.segment = this.__isset.segment;
      if((Key != null) && __isset.key)
      {
        tmp387.Key = this.Key.ToArray();
      }
      tmp387.__isset.key = this.__isset.key;
      return tmp387;
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
              if (field.Type == TType.String)
              {
                Segment = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Key = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp388 = new TStruct("GetReq");
        await oprot.WriteStructBeginAsync(tmp388, cancellationToken);
        var tmp389 = new TField();
        if((Segment != null) && __isset.segment)
        {
          tmp389.Name = "segment";
          tmp389.Type = TType.String;
          tmp389.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp389, cancellationToken);
          await oprot.WriteBinaryAsync(Segment, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Key != null) && __isset.key)
        {
          tmp389.Name = "key";
          tmp389.Type = TType.String;
          tmp389.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp389, cancellationToken);
          await oprot.WriteBinaryAsync(Key, cancellationToken);
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
      if (!(that is GetReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.segment == other.__isset.segment) && ((!__isset.segment) || (TCollections.Equals(Segment, other.Segment))))
        && ((__isset.key == other.__isset.key) && ((!__isset.key) || (TCollections.Equals(Key, other.Key))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Segment != null) && __isset.segment)
        {
          hashcode = (hashcode * 397) + Segment.GetHashCode();
        }
        if((Key != null) && __isset.key)
        {
          hashcode = (hashcode * 397) + Key.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp390 = new StringBuilder("GetReq(");
      int tmp391 = 0;
      if((Segment != null) && __isset.segment)
      {
        if(0 < tmp391++) { tmp390.Append(", "); }
        tmp390.Append("Segment: ");
        Segment.ToString(tmp390);
      }
      if((Key != null) && __isset.key)
      {
        if(0 < tmp391++) { tmp390.Append(", "); }
        tmp390.Append("Key: ");
        Key.ToString(tmp390);
      }
      tmp390.Append(')');
      return tmp390.ToString();
    }
  }

}