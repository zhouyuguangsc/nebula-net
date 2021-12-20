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

namespace Nebula.Graph
{

  public partial class ExecutionResponse : TBase
  {
    private global::Nebula.Common.DataSet _data;
    private byte[] _space_name;
    private byte[] _error_msg;
    private global::Nebula.Graph.PlanDescription _plan_desc;
    private byte[] _comment;

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Common.ErrorCode"/>
    /// </summary>
    public global::Nebula.Common.ErrorCode Error_code { get; set; }

    public int Latency_in_us { get; set; }

    public global::Nebula.Common.DataSet Data
    {
      get
      {
        return _data;
      }
      set
      {
        __isset.data = true;
        this._data = value;
      }
    }

    public byte[] Space_name
    {
      get
      {
        return _space_name;
      }
      set
      {
        __isset.space_name = true;
        this._space_name = value;
      }
    }

    public byte[] Error_msg
    {
      get
      {
        return _error_msg;
      }
      set
      {
        __isset.error_msg = true;
        this._error_msg = value;
      }
    }

    public global::Nebula.Graph.PlanDescription Plan_desc
    {
      get
      {
        return _plan_desc;
      }
      set
      {
        __isset.plan_desc = true;
        this._plan_desc = value;
      }
    }

    public byte[] Comment
    {
      get
      {
        return _comment;
      }
      set
      {
        __isset.comment = true;
        this._comment = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool data;
      public bool space_name;
      public bool error_msg;
      public bool plan_desc;
      public bool comment;
    }

    public ExecutionResponse()
    {
    }

    public ExecutionResponse(global::Nebula.Common.ErrorCode error_code, int latency_in_us) : this()
    {
      this.Error_code = error_code;
      this.Latency_in_us = latency_in_us;
    }

    public ExecutionResponse DeepCopy()
    {
      var tmp51 = new ExecutionResponse();
      tmp51.Error_code = this.Error_code;
      tmp51.Latency_in_us = this.Latency_in_us;
      if((Data != null) && __isset.data)
      {
        tmp51.Data = (global::Nebula.Common.DataSet)this.Data.DeepCopy();
      }
      tmp51.__isset.data = this.__isset.data;
      if((Space_name != null) && __isset.space_name)
      {
        tmp51.Space_name = this.Space_name.ToArray();
      }
      tmp51.__isset.space_name = this.__isset.space_name;
      if((Error_msg != null) && __isset.error_msg)
      {
        tmp51.Error_msg = this.Error_msg.ToArray();
      }
      tmp51.__isset.error_msg = this.__isset.error_msg;
      if((Plan_desc != null) && __isset.plan_desc)
      {
        tmp51.Plan_desc = (global::Nebula.Graph.PlanDescription)this.Plan_desc.DeepCopy();
      }
      tmp51.__isset.plan_desc = this.__isset.plan_desc;
      if((Comment != null) && __isset.comment)
      {
        tmp51.Comment = this.Comment.ToArray();
      }
      tmp51.__isset.comment = this.__isset.comment;
      return tmp51;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_error_code = false;
        bool isset_latency_in_us = false;
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
                Error_code = (global::Nebula.Common.ErrorCode)await iprot.ReadI32Async(cancellationToken);
                isset_error_code = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                Latency_in_us = await iprot.ReadI32Async(cancellationToken);
                isset_latency_in_us = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                Data = new global::Nebula.Common.DataSet();
                await Data.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                Space_name = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.String)
              {
                Error_msg = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Struct)
              {
                Plan_desc = new global::Nebula.Graph.PlanDescription();
                await Plan_desc.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.String)
              {
                Comment = await iprot.ReadBinaryAsync(cancellationToken);
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
        if (!isset_error_code)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_latency_in_us)
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
        var tmp52 = new TStruct("ExecutionResponse");
        await oprot.WriteStructBeginAsync(tmp52, cancellationToken);
        var tmp53 = new TField();
        tmp53.Name = "error_code";
        tmp53.Type = TType.I32;
        tmp53.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp53, cancellationToken);
        await oprot.WriteI32Async((int)Error_code, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        tmp53.Name = "latency_in_us";
        tmp53.Type = TType.I32;
        tmp53.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp53, cancellationToken);
        await oprot.WriteI32Async(Latency_in_us, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((Data != null) && __isset.data)
        {
          tmp53.Name = "data";
          tmp53.Type = TType.Struct;
          tmp53.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp53, cancellationToken);
          await Data.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Space_name != null) && __isset.space_name)
        {
          tmp53.Name = "space_name";
          tmp53.Type = TType.String;
          tmp53.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp53, cancellationToken);
          await oprot.WriteBinaryAsync(Space_name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Error_msg != null) && __isset.error_msg)
        {
          tmp53.Name = "error_msg";
          tmp53.Type = TType.String;
          tmp53.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp53, cancellationToken);
          await oprot.WriteBinaryAsync(Error_msg, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Plan_desc != null) && __isset.plan_desc)
        {
          tmp53.Name = "plan_desc";
          tmp53.Type = TType.Struct;
          tmp53.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp53, cancellationToken);
          await Plan_desc.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Comment != null) && __isset.comment)
        {
          tmp53.Name = "comment";
          tmp53.Type = TType.String;
          tmp53.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp53, cancellationToken);
          await oprot.WriteBinaryAsync(Comment, cancellationToken);
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
      if (!(that is ExecutionResponse other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Error_code, other.Error_code)
        && System.Object.Equals(Latency_in_us, other.Latency_in_us)
        && ((__isset.data == other.__isset.data) && ((!__isset.data) || (System.Object.Equals(Data, other.Data))))
        && ((__isset.space_name == other.__isset.space_name) && ((!__isset.space_name) || (TCollections.Equals(Space_name, other.Space_name))))
        && ((__isset.error_msg == other.__isset.error_msg) && ((!__isset.error_msg) || (TCollections.Equals(Error_msg, other.Error_msg))))
        && ((__isset.plan_desc == other.__isset.plan_desc) && ((!__isset.plan_desc) || (System.Object.Equals(Plan_desc, other.Plan_desc))))
        && ((__isset.comment == other.__isset.comment) && ((!__isset.comment) || (TCollections.Equals(Comment, other.Comment))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Error_code.GetHashCode();
        hashcode = (hashcode * 397) + Latency_in_us.GetHashCode();
        if((Data != null) && __isset.data)
        {
          hashcode = (hashcode * 397) + Data.GetHashCode();
        }
        if((Space_name != null) && __isset.space_name)
        {
          hashcode = (hashcode * 397) + Space_name.GetHashCode();
        }
        if((Error_msg != null) && __isset.error_msg)
        {
          hashcode = (hashcode * 397) + Error_msg.GetHashCode();
        }
        if((Plan_desc != null) && __isset.plan_desc)
        {
          hashcode = (hashcode * 397) + Plan_desc.GetHashCode();
        }
        if((Comment != null) && __isset.comment)
        {
          hashcode = (hashcode * 397) + Comment.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp54 = new StringBuilder("ExecutionResponse(");
      tmp54.Append(", Error_code: ");
      Error_code.ToString(tmp54);
      tmp54.Append(", Latency_in_us: ");
      Latency_in_us.ToString(tmp54);
      if((Data != null) && __isset.data)
      {
        tmp54.Append(", Data: ");
        Data.ToString(tmp54);
      }
      if((Space_name != null) && __isset.space_name)
      {
        tmp54.Append(", Space_name: ");
        Space_name.ToString(tmp54);
      }
      if((Error_msg != null) && __isset.error_msg)
      {
        tmp54.Append(", Error_msg: ");
        Error_msg.ToString(tmp54);
      }
      if((Plan_desc != null) && __isset.plan_desc)
      {
        tmp54.Append(", Plan_desc: ");
        Plan_desc.ToString(tmp54);
      }
      if((Comment != null) && __isset.comment)
      {
        tmp54.Append(", Comment: ");
        Comment.ToString(tmp54);
      }
      tmp54.Append(')');
      return tmp54.ToString();
    }
  }

}