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

  public partial class CreateFTIndexReq : TBase
  {
    private byte[] _fulltext_index_name;
    private global::Nebula.Meta.FTIndex _index;

    public byte[] Fulltext_index_name
    {
      get
      {
        return _fulltext_index_name;
      }
      set
      {
        __isset.fulltext_index_name = true;
        this._fulltext_index_name = value;
      }
    }

    public global::Nebula.Meta.FTIndex Index
    {
      get
      {
        return _index;
      }
      set
      {
        __isset.index = true;
        this._index = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool fulltext_index_name;
      public bool index;
    }

    public CreateFTIndexReq()
    {
    }

    public CreateFTIndexReq DeepCopy()
    {
      var tmp999 = new CreateFTIndexReq();
      if((Fulltext_index_name != null) && __isset.fulltext_index_name)
      {
        tmp999.Fulltext_index_name = this.Fulltext_index_name.ToArray();
      }
      tmp999.__isset.fulltext_index_name = this.__isset.fulltext_index_name;
      if((Index != null) && __isset.index)
      {
        tmp999.Index = (global::Nebula.Meta.FTIndex)this.Index.DeepCopy();
      }
      tmp999.__isset.index = this.__isset.index;
      return tmp999;
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
                Fulltext_index_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Index = new global::Nebula.Meta.FTIndex();
                await Index.ReadAsync(iprot, cancellationToken);
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
        var tmp1000 = new TStruct("CreateFTIndexReq");
        await oprot.WriteStructBeginAsync(tmp1000, cancellationToken);
        var tmp1001 = new TField();
        if((Fulltext_index_name != null) && __isset.fulltext_index_name)
        {
          tmp1001.Name = "fulltext_index_name";
          tmp1001.Type = TType.String;
          tmp1001.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp1001, cancellationToken);
          await oprot.WriteBinaryAsync(Fulltext_index_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Index != null) && __isset.index)
        {
          tmp1001.Name = "index";
          tmp1001.Type = TType.Struct;
          tmp1001.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp1001, cancellationToken);
          await Index.WriteAsync(oprot, cancellationToken);
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
      if (!(that is CreateFTIndexReq other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.fulltext_index_name == other.__isset.fulltext_index_name) && ((!__isset.fulltext_index_name) || (TCollections.Equals(Fulltext_index_name, other.Fulltext_index_name))))
        && ((__isset.index == other.__isset.index) && ((!__isset.index) || (System.Object.Equals(Index, other.Index))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Fulltext_index_name != null) && __isset.fulltext_index_name)
        {
          hashcode = (hashcode * 397) + Fulltext_index_name.GetHashCode();
        }
        if((Index != null) && __isset.index)
        {
          hashcode = (hashcode * 397) + Index.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp1002 = new StringBuilder("CreateFTIndexReq(");
      int tmp1003 = 0;
      if((Fulltext_index_name != null) && __isset.fulltext_index_name)
      {
        if(0 < tmp1003++) { tmp1002.Append(", "); }
        tmp1002.Append("Fulltext_index_name: ");
        Fulltext_index_name.ToString(tmp1002);
      }
      if((Index != null) && __isset.index)
      {
        if(0 < tmp1003++) { tmp1002.Append(", "); }
        tmp1002.Append("Index: ");
        Index.ToString(tmp1002);
      }
      tmp1002.Append(')');
      return tmp1002.ToString();
    }
  }

}
