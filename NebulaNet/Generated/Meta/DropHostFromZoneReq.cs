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

  public partial class DropHostFromZoneReq : TBase
  {
    private global::Nebula.Common.HostAddr _node;
    private byte[] _zone_name;

    public global::Nebula.Common.HostAddr Node
    {
      get
      {
        return _node;
      }
      set
      {
        __isset.node = true;
        this._node = value;
      }
    }

    public byte[] Zone_name
    {
      get
      {
        return _zone_name;
      }
      set
      {
        __isset.zone_name = true;
        this._zone_name = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool node;
      public bool zone_name;
    }

    public DropHostFromZoneReq()
    {
    }

    public DropHostFromZoneReq DeepCopy()
    {
      var tmp751 = new DropHostFromZoneReq();
      if((Node != null) && __isset.node)
      {
        tmp751.Node = (global::Nebula.Common.HostAddr)this.Node.DeepCopy();
      }
      tmp751.__isset.node = this.__isset.node;
      if((Zone_name != null) && __isset.zone_name)
      {
        tmp751.Zone_name = this.Zone_name.ToArray();
      }
      tmp751.__isset.zone_name = this.__isset.zone_name;
      return tmp751;
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
              if (field.Type == TType.Struct)
              {
                Node = new global::Nebula.Common.HostAddr();
                await Node.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Zone_name = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp752 = new TStruct("DropHostFromZoneReq");
        await oprot.WriteStructBeginAsync(tmp752, cancellationToken);
        var tmp753 = new TField();
        if((Node != null) && __isset.node)
        {
          tmp753.Name = "node";
          tmp753.Type = TType.Struct;
          tmp753.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp753, cancellationToken);
          await Node.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Zone_name != null) && __isset.zone_name)
        {
          tmp753.Name = "zone_name";
          tmp753.Type = TType.String;
          tmp753.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp753, cancellationToken);
          await oprot.WriteBinaryAsync(Zone_name, cancellationToken);
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
      if (!(that is DropHostFromZoneReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.node == other.__isset.node) && ((!__isset.node) || (System.Object.Equals(Node, other.Node))))
        && ((__isset.zone_name == other.__isset.zone_name) && ((!__isset.zone_name) || (TCollections.Equals(Zone_name, other.Zone_name))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Node != null) && __isset.node)
        {
          hashcode = (hashcode * 397) + Node.GetHashCode();
        }
        if((Zone_name != null) && __isset.zone_name)
        {
          hashcode = (hashcode * 397) + Zone_name.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp754 = new StringBuilder("DropHostFromZoneReq(");
      int tmp755 = 0;
      if((Node != null) && __isset.node)
      {
        if(0 < tmp755++) { tmp754.Append(", "); }
        tmp754.Append("Node: ");
        Node.ToString(tmp754);
      }
      if((Zone_name != null) && __isset.zone_name)
      {
        if(0 < tmp755++) { tmp754.Append(", "); }
        tmp754.Append("Zone_name: ");
        Zone_name.ToString(tmp754);
      }
      tmp754.Append(')');
      return tmp754.ToString();
    }
  }

}