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

  public partial class NewVertex : TBase
  {
    private global::Nebula.Common.@Value _id;
    private List<global::Nebula.Storage.NewTag> _tags;

    public global::Nebula.Common.@Value Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public List<global::Nebula.Storage.NewTag> Tags
    {
      get
      {
        return _tags;
      }
      set
      {
        __isset.tags = true;
        this._tags = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool id;
      public bool tags;
    }

    public NewVertex()
    {
    }

    public NewVertex DeepCopy()
    {
      var tmp158 = new NewVertex();
      if((Id != null) && __isset.id)
      {
        tmp158.Id = (global::Nebula.Common.@Value)this.Id.DeepCopy();
      }
      tmp158.__isset.id = this.__isset.id;
      if((Tags != null) && __isset.tags)
      {
        tmp158.Tags = this.Tags.DeepCopy();
      }
      tmp158.__isset.tags = this.__isset.tags;
      return tmp158;
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
                Id = new global::Nebula.Common.@Value();
                await Id.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list159 = await iprot.ReadListBeginAsync(cancellationToken);
                  Tags = new List<global::Nebula.Storage.NewTag>(_list159.Count);
                  for(int _i160 = 0; _i160 < _list159.Count; ++_i160)
                  {
                    global::Nebula.Storage.NewTag _elem161;
                    _elem161 = new global::Nebula.Storage.NewTag();
                    await _elem161.ReadAsync(iprot, cancellationToken);
                    Tags.Add(_elem161);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var tmp162 = new TStruct("NewVertex");
        await oprot.WriteStructBeginAsync(tmp162, cancellationToken);
        var tmp163 = new TField();
        if((Id != null) && __isset.id)
        {
          tmp163.Name = "id";
          tmp163.Type = TType.Struct;
          tmp163.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp163, cancellationToken);
          await Id.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Tags != null) && __isset.tags)
        {
          tmp163.Name = "tags";
          tmp163.Type = TType.List;
          tmp163.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp163, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Tags.Count), cancellationToken);
            foreach (global::Nebula.Storage.NewTag _iter164 in Tags)
            {
              await _iter164.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      if (!(that is NewVertex other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.id == other.__isset.id) && ((!__isset.id) || (System.Object.Equals(Id, other.Id))))
        && ((__isset.tags == other.__isset.tags) && ((!__isset.tags) || (TCollections.Equals(Tags, other.Tags))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Id != null) && __isset.id)
        {
          hashcode = (hashcode * 397) + Id.GetHashCode();
        }
        if((Tags != null) && __isset.tags)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Tags);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp165 = new StringBuilder("NewVertex(");
      int tmp166 = 0;
      if((Id != null) && __isset.id)
      {
        if(0 < tmp166++) { tmp165.Append(", "); }
        tmp165.Append("Id: ");
        Id.ToString(tmp165);
      }
      if((Tags != null) && __isset.tags)
      {
        if(0 < tmp166++) { tmp165.Append(", "); }
        tmp165.Append("Tags: ");
        Tags.ToString(tmp165);
      }
      tmp165.Append(')');
      return tmp165.ToString();
    }
  }

}
