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

  public partial class NewTag : TBase
  {
    private int _tag_id;
    private List<global::Nebula.Common.@Value> _props;

    public int Tag_id
    {
      get
      {
        return _tag_id;
      }
      set
      {
        __isset.tag_id = true;
        this._tag_id = value;
      }
    }

    public List<global::Nebula.Common.@Value> Props
    {
      get
      {
        return _props;
      }
      set
      {
        __isset.props = true;
        this._props = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool tag_id;
      public bool props;
    }

    public NewTag()
    {
    }

    public NewTag DeepCopy()
    {
      var tmp149 = new NewTag();
      if(__isset.tag_id)
      {
        tmp149.Tag_id = this.Tag_id;
      }
      tmp149.__isset.tag_id = this.__isset.tag_id;
      if((Props != null) && __isset.props)
      {
        tmp149.Props = this.Props.DeepCopy();
      }
      tmp149.__isset.props = this.__isset.props;
      return tmp149;
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
                Tag_id = await iprot.ReadI32Async(cancellationToken);
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
                  TList _list150 = await iprot.ReadListBeginAsync(cancellationToken);
                  Props = new List<global::Nebula.Common.@Value>(_list150.Count);
                  for(int _i151 = 0; _i151 < _list150.Count; ++_i151)
                  {
                    global::Nebula.Common.@Value _elem152;
                    _elem152 = new global::Nebula.Common.@Value();
                    await _elem152.ReadAsync(iprot, cancellationToken);
                    Props.Add(_elem152);
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
        var tmp153 = new TStruct("NewTag");
        await oprot.WriteStructBeginAsync(tmp153, cancellationToken);
        var tmp154 = new TField();
        if(__isset.tag_id)
        {
          tmp154.Name = "tag_id";
          tmp154.Type = TType.I32;
          tmp154.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp154, cancellationToken);
          await oprot.WriteI32Async(Tag_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Props != null) && __isset.props)
        {
          tmp154.Name = "props";
          tmp154.Type = TType.List;
          tmp154.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp154, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Props.Count), cancellationToken);
            foreach (global::Nebula.Common.@Value _iter155 in Props)
            {
              await _iter155.WriteAsync(oprot, cancellationToken);
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
      if (!(that is NewTag other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.tag_id == other.__isset.tag_id) && ((!__isset.tag_id) || (System.Object.Equals(Tag_id, other.Tag_id))))
        && ((__isset.props == other.__isset.props) && ((!__isset.props) || (TCollections.Equals(Props, other.Props))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.tag_id)
        {
          hashcode = (hashcode * 397) + Tag_id.GetHashCode();
        }
        if((Props != null) && __isset.props)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Props);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp156 = new StringBuilder("NewTag(");
      int tmp157 = 0;
      if(__isset.tag_id)
      {
        if(0 < tmp157++) { tmp156.Append(", "); }
        tmp156.Append("Tag_id: ");
        Tag_id.ToString(tmp156);
      }
      if((Props != null) && __isset.props)
      {
        if(0 < tmp157++) { tmp156.Append(", "); }
        tmp156.Append("Props: ");
        Props.ToString(tmp156);
      }
      tmp156.Append(')');
      return tmp156.ToString();
    }
  }

}