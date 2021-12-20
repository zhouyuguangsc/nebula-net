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

  public partial class GetNeighborsResponse : TBase
  {
    private global::Nebula.Common.DataSet _vertices;

    public global::Nebula.Storage.ResponseCommon Result { get; set; }

    public global::Nebula.Common.DataSet Vertices
    {
      get
      {
        return _vertices;
      }
      set
      {
        __isset.vertices = true;
        this._vertices = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool vertices;
    }

    public GetNeighborsResponse()
    {
    }

    public GetNeighborsResponse(global::Nebula.Storage.ResponseCommon result) : this()
    {
      this.Result = result;
    }

    public GetNeighborsResponse DeepCopy()
    {
      var tmp104 = new GetNeighborsResponse();
      if((Result != null))
      {
        tmp104.Result = (global::Nebula.Storage.ResponseCommon)this.Result.DeepCopy();
      }
      if((Vertices != null) && __isset.vertices)
      {
        tmp104.Vertices = (global::Nebula.Common.DataSet)this.Vertices.DeepCopy();
      }
      tmp104.__isset.vertices = this.__isset.vertices;
      return tmp104;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_result = false;
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
                Result = new global::Nebula.Storage.ResponseCommon();
                await Result.ReadAsync(iprot, cancellationToken);
                isset_result = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Vertices = new global::Nebula.Common.DataSet();
                await Vertices.ReadAsync(iprot, cancellationToken);
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
        if (!isset_result)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
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
        var tmp105 = new TStruct("GetNeighborsResponse");
        await oprot.WriteStructBeginAsync(tmp105, cancellationToken);
        var tmp106 = new TField();
        if((Result != null))
        {
          tmp106.Name = "result";
          tmp106.Type = TType.Struct;
          tmp106.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp106, cancellationToken);
          await Result.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Vertices != null) && __isset.vertices)
        {
          tmp106.Name = "vertices";
          tmp106.Type = TType.Struct;
          tmp106.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp106, cancellationToken);
          await Vertices.WriteAsync(oprot, cancellationToken);
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
      if (!(that is GetNeighborsResponse other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Result, other.Result)
        && ((__isset.vertices == other.__isset.vertices) && ((!__isset.vertices) || (System.Object.Equals(Vertices, other.Vertices))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Result != null))
        {
          hashcode = (hashcode * 397) + Result.GetHashCode();
        }
        if((Vertices != null) && __isset.vertices)
        {
          hashcode = (hashcode * 397) + Vertices.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp107 = new StringBuilder("GetNeighborsResponse(");
      if((Result != null))
      {
        tmp107.Append(", Result: ");
        Result.ToString(tmp107);
      }
      if((Vertices != null) && __isset.vertices)
      {
        tmp107.Append(", Vertices: ");
        Vertices.ToString(tmp107);
      }
      tmp107.Append(')');
      return tmp107.ToString();
    }
  }

}