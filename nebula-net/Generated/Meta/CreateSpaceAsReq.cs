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

  public partial class CreateSpaceAsReq : TBase
  {
    private byte[] _old_space_name;
    private byte[] _new_space_name;

    public byte[] Old_space_name
    {
      get
      {
        return _old_space_name;
      }
      set
      {
        __isset.old_space_name = true;
        this._old_space_name = value;
      }
    }

    public byte[] New_space_name
    {
      get
      {
        return _new_space_name;
      }
      set
      {
        __isset.new_space_name = true;
        this._new_space_name = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool old_space_name;
      public bool new_space_name;
    }

    public CreateSpaceAsReq()
    {
    }

    public CreateSpaceAsReq DeepCopy()
    {
      var tmp190 = new CreateSpaceAsReq();
      if((Old_space_name != null) && __isset.old_space_name)
      {
        tmp190.Old_space_name = this.Old_space_name.ToArray();
      }
      tmp190.__isset.old_space_name = this.__isset.old_space_name;
      if((New_space_name != null) && __isset.new_space_name)
      {
        tmp190.New_space_name = this.New_space_name.ToArray();
      }
      tmp190.__isset.new_space_name = this.__isset.new_space_name;
      return tmp190;
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
                Old_space_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                New_space_name = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp191 = new TStruct("CreateSpaceAsReq");
        await oprot.WriteStructBeginAsync(tmp191, cancellationToken);
        var tmp192 = new TField();
        if((Old_space_name != null) && __isset.old_space_name)
        {
          tmp192.Name = "old_space_name";
          tmp192.Type = TType.String;
          tmp192.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp192, cancellationToken);
          await oprot.WriteBinaryAsync(Old_space_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((New_space_name != null) && __isset.new_space_name)
        {
          tmp192.Name = "new_space_name";
          tmp192.Type = TType.String;
          tmp192.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp192, cancellationToken);
          await oprot.WriteBinaryAsync(New_space_name, cancellationToken);
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
      if (!(that is CreateSpaceAsReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.old_space_name == other.__isset.old_space_name) && ((!__isset.old_space_name) || (TCollections.Equals(Old_space_name, other.Old_space_name))))
        && ((__isset.new_space_name == other.__isset.new_space_name) && ((!__isset.new_space_name) || (TCollections.Equals(New_space_name, other.New_space_name))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Old_space_name != null) && __isset.old_space_name)
        {
          hashcode = (hashcode * 397) + Old_space_name.GetHashCode();
        }
        if((New_space_name != null) && __isset.new_space_name)
        {
          hashcode = (hashcode * 397) + New_space_name.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp193 = new StringBuilder("CreateSpaceAsReq(");
      int tmp194 = 0;
      if((Old_space_name != null) && __isset.old_space_name)
      {
        if(0 < tmp194++) { tmp193.Append(", "); }
        tmp193.Append("Old_space_name: ");
        Old_space_name.ToString(tmp193);
      }
      if((New_space_name != null) && __isset.new_space_name)
      {
        if(0 < tmp194++) { tmp193.Append(", "); }
        tmp193.Append("New_space_name: ");
        New_space_name.ToString(tmp193);
      }
      tmp193.Append(')');
      return tmp193.ToString();
    }
  }

}
