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

  public partial class VerifyClientVersionResp : TBase
  {
    private byte[] _error_msg;

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Common.ErrorCode"/>
    /// </summary>
    public global::Nebula.Common.ErrorCode Error_code { get; set; }

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


    public Isset __isset;
    public struct Isset
    {
      public bool error_msg;
    }

    public VerifyClientVersionResp()
    {
    }

    public VerifyClientVersionResp(global::Nebula.Common.ErrorCode error_code) : this()
    {
      this.Error_code = error_code;
    }

    public VerifyClientVersionResp DeepCopy()
    {
      var tmp61 = new VerifyClientVersionResp();
      tmp61.Error_code = this.Error_code;
      if((Error_msg != null) && __isset.error_msg)
      {
        tmp61.Error_msg = this.Error_msg.ToArray();
      }
      tmp61.__isset.error_msg = this.__isset.error_msg;
      return tmp61;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_error_code = false;
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
              if (field.Type == TType.String)
              {
                Error_msg = await iprot.ReadBinaryAsync(cancellationToken);
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
        var tmp62 = new TStruct("VerifyClientVersionResp");
        await oprot.WriteStructBeginAsync(tmp62, cancellationToken);
        var tmp63 = new TField();
        tmp63.Name = "error_code";
        tmp63.Type = TType.I32;
        tmp63.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp63, cancellationToken);
        await oprot.WriteI32Async((int)Error_code, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((Error_msg != null) && __isset.error_msg)
        {
          tmp63.Name = "error_msg";
          tmp63.Type = TType.String;
          tmp63.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp63, cancellationToken);
          await oprot.WriteBinaryAsync(Error_msg, cancellationToken);
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
      if (!(that is VerifyClientVersionResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Error_code, other.Error_code)
        && ((__isset.error_msg == other.__isset.error_msg) && ((!__isset.error_msg) || (TCollections.Equals(Error_msg, other.Error_msg))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Error_code.GetHashCode();
        if((Error_msg != null) && __isset.error_msg)
        {
          hashcode = (hashcode * 397) + Error_msg.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp64 = new StringBuilder("VerifyClientVersionResp(");
      tmp64.Append(", Error_code: ");
      Error_code.ToString(tmp64);
      if((Error_msg != null) && __isset.error_msg)
      {
        tmp64.Append(", Error_msg: ");
        Error_msg.ToString(tmp64);
      }
      tmp64.Append(')');
      return tmp64.ToString();
    }
  }

}