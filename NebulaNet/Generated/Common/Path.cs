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

namespace Nebula.Common
{

  public partial class Path : TBase
  {
    private global::Nebula.Common.Vertex _src;
    private List<global::Nebula.Common.Step> _steps;

    public global::Nebula.Common.Vertex Src
    {
      get
      {
        return _src;
      }
      set
      {
        __isset.src = true;
        this._src = value;
      }
    }

    public List<global::Nebula.Common.Step> Steps
    {
      get
      {
        return _steps;
      }
      set
      {
        __isset.steps = true;
        this._steps = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool src;
      public bool steps;
    }

    public Path()
    {
    }

    public Path DeepCopy()
    {
      var tmp151 = new Path();
      if((Src != null) && __isset.src)
      {
        tmp151.Src = (global::Nebula.Common.Vertex)this.Src.DeepCopy();
      }
      tmp151.__isset.src = this.__isset.src;
      if((Steps != null) && __isset.steps)
      {
        tmp151.Steps = this.Steps.DeepCopy();
      }
      tmp151.__isset.steps = this.__isset.steps;
      return tmp151;
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
                Src = new global::Nebula.Common.Vertex();
                await Src.ReadAsync(iprot, cancellationToken);
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
                  TList _list152 = await iprot.ReadListBeginAsync(cancellationToken);
                  Steps = new List<global::Nebula.Common.Step>(_list152.Count);
                  for(int _i153 = 0; _i153 < _list152.Count; ++_i153)
                  {
                    global::Nebula.Common.Step _elem154;
                    _elem154 = new global::Nebula.Common.Step();
                    await _elem154.ReadAsync(iprot, cancellationToken);
                    Steps.Add(_elem154);
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
        var tmp155 = new TStruct("Path");
        await oprot.WriteStructBeginAsync(tmp155, cancellationToken);
        var tmp156 = new TField();
        if((Src != null) && __isset.src)
        {
          tmp156.Name = "src";
          tmp156.Type = TType.Struct;
          tmp156.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp156, cancellationToken);
          await Src.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Steps != null) && __isset.steps)
        {
          tmp156.Name = "steps";
          tmp156.Type = TType.List;
          tmp156.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp156, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Steps.Count), cancellationToken);
            foreach (global::Nebula.Common.Step _iter157 in Steps)
            {
              await _iter157.WriteAsync(oprot, cancellationToken);
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
      if (!(that is Path other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.src == other.__isset.src) && ((!__isset.src) || (System.Object.Equals(Src, other.Src))))
        && ((__isset.steps == other.__isset.steps) && ((!__isset.steps) || (TCollections.Equals(Steps, other.Steps))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Src != null) && __isset.src)
        {
          hashcode = (hashcode * 397) + Src.GetHashCode();
        }
        if((Steps != null) && __isset.steps)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Steps);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp158 = new StringBuilder("Path(");
      int tmp159 = 0;
      if((Src != null) && __isset.src)
      {
        if(0 < tmp159++) { tmp158.Append(", "); }
        tmp158.Append("Src: ");
        Src.ToString(tmp158);
      }
      if((Steps != null) && __isset.steps)
      {
        if(0 < tmp159++) { tmp158.Append(", "); }
        tmp158.Append("Steps: ");
        Steps.ToString(tmp158);
      }
      tmp158.Append(')');
      return tmp158.ToString();
    }
  }

}