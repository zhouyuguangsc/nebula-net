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

  public partial class AddZoneIntoGroupReq : TBase
  {
    private byte[] _zone_name;
    private byte[] _group_name;

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

    public byte[] Group_name
    {
      get
      {
        return _group_name;
      }
      set
      {
        __isset.group_name = true;
        this._group_name = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool zone_name;
      public bool group_name;
    }

    public AddZoneIntoGroupReq()
    {
    }

    public AddZoneIntoGroupReq DeepCopy()
    {
      var tmp806 = new AddZoneIntoGroupReq();
      if((Zone_name != null) && __isset.zone_name)
      {
        tmp806.Zone_name = this.Zone_name.ToArray();
      }
      tmp806.__isset.zone_name = this.__isset.zone_name;
      if((Group_name != null) && __isset.group_name)
      {
        tmp806.Group_name = this.Group_name.ToArray();
      }
      tmp806.__isset.group_name = this.__isset.group_name;
      return tmp806;
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
                Zone_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Group_name = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp807 = new TStruct("AddZoneIntoGroupReq");
        await oprot.WriteStructBeginAsync(tmp807, cancellationToken);
        var tmp808 = new TField();
        if((Zone_name != null) && __isset.zone_name)
        {
          tmp808.Name = "zone_name";
          tmp808.Type = TType.String;
          tmp808.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp808, cancellationToken);
          await oprot.WriteBinaryAsync(Zone_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Group_name != null) && __isset.group_name)
        {
          tmp808.Name = "group_name";
          tmp808.Type = TType.String;
          tmp808.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp808, cancellationToken);
          await oprot.WriteBinaryAsync(Group_name, cancellationToken);
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
      if (!(that is AddZoneIntoGroupReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.zone_name == other.__isset.zone_name) && ((!__isset.zone_name) || (TCollections.Equals(Zone_name, other.Zone_name))))
        && ((__isset.group_name == other.__isset.group_name) && ((!__isset.group_name) || (TCollections.Equals(Group_name, other.Group_name))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Zone_name != null) && __isset.zone_name)
        {
          hashcode = (hashcode * 397) + Zone_name.GetHashCode();
        }
        if((Group_name != null) && __isset.group_name)
        {
          hashcode = (hashcode * 397) + Group_name.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp809 = new StringBuilder("AddZoneIntoGroupReq(");
      int tmp810 = 0;
      if((Zone_name != null) && __isset.zone_name)
      {
        if(0 < tmp810++) { tmp809.Append(", "); }
        tmp809.Append("Zone_name: ");
        Zone_name.ToString(tmp809);
      }
      if((Group_name != null) && __isset.group_name)
      {
        if(0 < tmp810++) { tmp809.Append(", "); }
        tmp809.Append("Group_name: ");
        Group_name.ToString(tmp809);
      }
      tmp809.Append(')');
      return tmp809.ToString();
    }
  }

}