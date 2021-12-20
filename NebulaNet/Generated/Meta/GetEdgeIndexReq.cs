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

  public partial class GetEdgeIndexReq : TBase
  {
    private int _space_id;
    private byte[] _index_name;

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

    public byte[] Index_name
    {
      get
      {
        return _index_name;
      }
      set
      {
        __isset.index_name = true;
        this._index_name = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool space_id;
      public bool index_name;
    }

    public GetEdgeIndexReq()
    {
    }

    public GetEdgeIndexReq DeepCopy()
    {
      var tmp520 = new GetEdgeIndexReq();
      if(__isset.space_id)
      {
        tmp520.Space_id = this.Space_id;
      }
      tmp520.__isset.space_id = this.__isset.space_id;
      if((Index_name != null) && __isset.index_name)
      {
        tmp520.Index_name = this.Index_name.ToArray();
      }
      tmp520.__isset.index_name = this.__isset.index_name;
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
              if (field.Type == TType.String)
              {
                Index_name = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp521 = new TStruct("GetEdgeIndexReq");
        await oprot.WriteStructBeginAsync(tmp521, cancellationToken);
        var tmp522 = new TField();
        if(__isset.space_id)
        {
          tmp522.Name = "space_id";
          tmp522.Type = TType.I32;
          tmp522.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp522, cancellationToken);
          await oprot.WriteI32Async(Space_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Index_name != null) && __isset.index_name)
        {
          tmp522.Name = "index_name";
          tmp522.Type = TType.String;
          tmp522.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp522, cancellationToken);
          await oprot.WriteBinaryAsync(Index_name, cancellationToken);
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
      if (!(that is GetEdgeIndexReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.space_id == other.__isset.space_id) && ((!__isset.space_id) || (System.Object.Equals(Space_id, other.Space_id))))
        && ((__isset.index_name == other.__isset.index_name) && ((!__isset.index_name) || (TCollections.Equals(Index_name, other.Index_name))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.space_id)
        {
          hashcode = (hashcode * 397) + Space_id.GetHashCode();
        }
        if((Index_name != null) && __isset.index_name)
        {
          hashcode = (hashcode * 397) + Index_name.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp523 = new StringBuilder("GetEdgeIndexReq(");
      int tmp524 = 0;
      if(__isset.space_id)
      {
        if(0 < tmp524++) { tmp523.Append(", "); }
        tmp523.Append("Space_id: ");
        Space_id.ToString(tmp523);
      }
      if((Index_name != null) && __isset.index_name)
      {
        if(0 < tmp524++) { tmp523.Append(", "); }
        tmp523.Append("Index_name: ");
        Index_name.ToString(tmp523);
      }
      tmp523.Append(')');
      return tmp523.ToString();
    }
  }

}