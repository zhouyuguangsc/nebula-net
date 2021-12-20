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
  public partial class GeneralStorageService
  {
    public interface IAsync
    {
      global::System.Threading.Tasks.Task<global::Nebula.Storage.KVGetResponse> @get(global::Nebula.Storage.KVGetRequest req, CancellationToken cancellationToken = default);

      global::System.Threading.Tasks.Task<global::Nebula.Storage.ExecResponse> put(global::Nebula.Storage.KVPutRequest req, CancellationToken cancellationToken = default);

      global::System.Threading.Tasks.Task<global::Nebula.Storage.ExecResponse> @remove(global::Nebula.Storage.KVRemoveRequest req, CancellationToken cancellationToken = default);

    }


    public class Client : TBaseClient, IDisposable, IAsync
    {
      public Client(TProtocol protocol) : this(protocol, protocol)
      {
      }

      public Client(TProtocol inputProtocol, TProtocol outputProtocol) : base(inputProtocol, outputProtocol)
      {
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.KVGetResponse> @get(global::Nebula.Storage.KVGetRequest req, CancellationToken cancellationToken = default)
      {
        await send_get(req, cancellationToken);
        return await recv_get(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task send_get(global::Nebula.Storage.KVGetRequest req, CancellationToken cancellationToken = default)
      {
        await OutputProtocol.WriteMessageBeginAsync(new TMessage("get", TMessageType.Call, SeqId), cancellationToken);
        
        var tmp1226 = new InternalStructs.get_args() {
          Req = req,
        };
        
        await tmp1226.WriteAsync(OutputProtocol, cancellationToken);
        await OutputProtocol.WriteMessageEndAsync(cancellationToken);
        await OutputProtocol.Transport.FlushAsync(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.KVGetResponse> recv_get(CancellationToken cancellationToken = default)
      {
        
        var tmp1227 = await InputProtocol.ReadMessageBeginAsync(cancellationToken);
        if (tmp1227.Type == TMessageType.Exception)
        {
          var tmp1228 = await TApplicationException.ReadAsync(InputProtocol, cancellationToken);
          await InputProtocol.ReadMessageEndAsync(cancellationToken);
          throw tmp1228;
        }

        var tmp1229 = new InternalStructs.get_result();
        await tmp1229.ReadAsync(InputProtocol, cancellationToken);
        await InputProtocol.ReadMessageEndAsync(cancellationToken);
        if (tmp1229.__isset.success)
        {
          return tmp1229.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "get failed: unknown result");
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.ExecResponse> put(global::Nebula.Storage.KVPutRequest req, CancellationToken cancellationToken = default)
      {
        await send_put(req, cancellationToken);
        return await recv_put(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task send_put(global::Nebula.Storage.KVPutRequest req, CancellationToken cancellationToken = default)
      {
        await OutputProtocol.WriteMessageBeginAsync(new TMessage("put", TMessageType.Call, SeqId), cancellationToken);
        
        var tmp1230 = new InternalStructs.put_args() {
          Req = req,
        };
        
        await tmp1230.WriteAsync(OutputProtocol, cancellationToken);
        await OutputProtocol.WriteMessageEndAsync(cancellationToken);
        await OutputProtocol.Transport.FlushAsync(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.ExecResponse> recv_put(CancellationToken cancellationToken = default)
      {
        
        var tmp1231 = await InputProtocol.ReadMessageBeginAsync(cancellationToken);
        if (tmp1231.Type == TMessageType.Exception)
        {
          var tmp1232 = await TApplicationException.ReadAsync(InputProtocol, cancellationToken);
          await InputProtocol.ReadMessageEndAsync(cancellationToken);
          throw tmp1232;
        }

        var tmp1233 = new InternalStructs.put_result();
        await tmp1233.ReadAsync(InputProtocol, cancellationToken);
        await InputProtocol.ReadMessageEndAsync(cancellationToken);
        if (tmp1233.__isset.success)
        {
          return tmp1233.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "put failed: unknown result");
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.ExecResponse> @remove(global::Nebula.Storage.KVRemoveRequest req, CancellationToken cancellationToken = default)
      {
        await send_remove(req, cancellationToken);
        return await recv_remove(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task send_remove(global::Nebula.Storage.KVRemoveRequest req, CancellationToken cancellationToken = default)
      {
        await OutputProtocol.WriteMessageBeginAsync(new TMessage("remove", TMessageType.Call, SeqId), cancellationToken);
        
        var tmp1234 = new InternalStructs.remove_args() {
          Req = req,
        };
        
        await tmp1234.WriteAsync(OutputProtocol, cancellationToken);
        await OutputProtocol.WriteMessageEndAsync(cancellationToken);
        await OutputProtocol.Transport.FlushAsync(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task<global::Nebula.Storage.ExecResponse> recv_remove(CancellationToken cancellationToken = default)
      {
        
        var tmp1235 = await InputProtocol.ReadMessageBeginAsync(cancellationToken);
        if (tmp1235.Type == TMessageType.Exception)
        {
          var tmp1236 = await TApplicationException.ReadAsync(InputProtocol, cancellationToken);
          await InputProtocol.ReadMessageEndAsync(cancellationToken);
          throw tmp1236;
        }

        var tmp1237 = new InternalStructs.remove_result();
        await tmp1237.ReadAsync(InputProtocol, cancellationToken);
        await InputProtocol.ReadMessageEndAsync(cancellationToken);
        if (tmp1237.__isset.success)
        {
          return tmp1237.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "remove failed: unknown result");
      }

    }

    public class AsyncProcessor : ITAsyncProcessor
    {
      private readonly IAsync _iAsync;
      private readonly ILogger<AsyncProcessor> _logger;

      public AsyncProcessor(IAsync iAsync, ILogger<AsyncProcessor> logger = default)
      {
        _iAsync = iAsync ?? throw new ArgumentNullException(nameof(iAsync));
        _logger = logger;
        processMap_["get"] = get_ProcessAsync;
        processMap_["put"] = put_ProcessAsync;
        processMap_["remove"] = remove_ProcessAsync;
      }

      protected delegate global::System.Threading.Tasks.Task ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken);
      protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

      public async Task<bool> ProcessAsync(TProtocol iprot, TProtocol oprot)
      {
        return await ProcessAsync(iprot, oprot, CancellationToken.None);
      }

      public async Task<bool> ProcessAsync(TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken)
      {
        try
        {
          var msg = await iprot.ReadMessageBeginAsync(cancellationToken);

          processMap_.TryGetValue(msg.Name, out ProcessFunction fn);

          if (fn == null)
          {
            await TProtocolUtil.SkipAsync(iprot, TType.Struct, cancellationToken);
            await iprot.ReadMessageEndAsync(cancellationToken);
            var x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
            await oprot.WriteMessageBeginAsync(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID), cancellationToken);
            await x.WriteAsync(oprot, cancellationToken);
            await oprot.WriteMessageEndAsync(cancellationToken);
            await oprot.Transport.FlushAsync(cancellationToken);
            return true;
          }

          await fn(msg.SeqID, iprot, oprot, cancellationToken);

        }
        catch (IOException)
        {
          return false;
        }

        return true;
      }

      public async global::System.Threading.Tasks.Task get_ProcessAsync(int seqid, TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken)
      {
        var tmp1238 = new InternalStructs.get_args();
        await tmp1238.ReadAsync(iprot, cancellationToken);
        await iprot.ReadMessageEndAsync(cancellationToken);
        var tmp1239 = new InternalStructs.get_result();
        try
        {
          tmp1239.Success = await _iAsync.@get(tmp1238.Req, cancellationToken);
          await oprot.WriteMessageBeginAsync(new TMessage("get", TMessageType.Reply, seqid), cancellationToken); 
          await tmp1239.WriteAsync(oprot, cancellationToken);
        }
        catch (TTransportException)
        {
          throw;
        }
        catch (Exception tmp1240)
        {
          var tmp1241 = $"Error occurred in {GetType().FullName}: {tmp1240.Message}";
          if(_logger != null)
            _logger.LogError(tmp1240, tmp1241);
          else
            Console.Error.WriteLine(tmp1241);
          var tmp1242 = new TApplicationException(TApplicationException.ExceptionType.InternalError," Internal error.");
          await oprot.WriteMessageBeginAsync(new TMessage("get", TMessageType.Exception, seqid), cancellationToken);
          await tmp1242.WriteAsync(oprot, cancellationToken);
        }
        await oprot.WriteMessageEndAsync(cancellationToken);
        await oprot.Transport.FlushAsync(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task put_ProcessAsync(int seqid, TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken)
      {
        var tmp1243 = new InternalStructs.put_args();
        await tmp1243.ReadAsync(iprot, cancellationToken);
        await iprot.ReadMessageEndAsync(cancellationToken);
        var tmp1244 = new InternalStructs.put_result();
        try
        {
          tmp1244.Success = await _iAsync.put(tmp1243.Req, cancellationToken);
          await oprot.WriteMessageBeginAsync(new TMessage("put", TMessageType.Reply, seqid), cancellationToken); 
          await tmp1244.WriteAsync(oprot, cancellationToken);
        }
        catch (TTransportException)
        {
          throw;
        }
        catch (Exception tmp1245)
        {
          var tmp1246 = $"Error occurred in {GetType().FullName}: {tmp1245.Message}";
          if(_logger != null)
            _logger.LogError(tmp1245, tmp1246);
          else
            Console.Error.WriteLine(tmp1246);
          var tmp1247 = new TApplicationException(TApplicationException.ExceptionType.InternalError," Internal error.");
          await oprot.WriteMessageBeginAsync(new TMessage("put", TMessageType.Exception, seqid), cancellationToken);
          await tmp1247.WriteAsync(oprot, cancellationToken);
        }
        await oprot.WriteMessageEndAsync(cancellationToken);
        await oprot.Transport.FlushAsync(cancellationToken);
      }

      public async global::System.Threading.Tasks.Task remove_ProcessAsync(int seqid, TProtocol iprot, TProtocol oprot, CancellationToken cancellationToken)
      {
        var tmp1248 = new InternalStructs.remove_args();
        await tmp1248.ReadAsync(iprot, cancellationToken);
        await iprot.ReadMessageEndAsync(cancellationToken);
        var tmp1249 = new InternalStructs.remove_result();
        try
        {
          tmp1249.Success = await _iAsync.@remove(tmp1248.Req, cancellationToken);
          await oprot.WriteMessageBeginAsync(new TMessage("remove", TMessageType.Reply, seqid), cancellationToken); 
          await tmp1249.WriteAsync(oprot, cancellationToken);
        }
        catch (TTransportException)
        {
          throw;
        }
        catch (Exception tmp1250)
        {
          var tmp1251 = $"Error occurred in {GetType().FullName}: {tmp1250.Message}";
          if(_logger != null)
            _logger.LogError(tmp1250, tmp1251);
          else
            Console.Error.WriteLine(tmp1251);
          var tmp1252 = new TApplicationException(TApplicationException.ExceptionType.InternalError," Internal error.");
          await oprot.WriteMessageBeginAsync(new TMessage("remove", TMessageType.Exception, seqid), cancellationToken);
          await tmp1252.WriteAsync(oprot, cancellationToken);
        }
        await oprot.WriteMessageEndAsync(cancellationToken);
        await oprot.Transport.FlushAsync(cancellationToken);
      }

    }

    public class InternalStructs
    {

      public partial class get_args : TBase
      {
        private global::Nebula.Storage.KVGetRequest _req;

        public global::Nebula.Storage.KVGetRequest Req
        {
          get
          {
            return _req;
          }
          set
          {
            __isset.req = true;
            this._req = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool req;
        }

        public get_args()
        {
        }

        public get_args DeepCopy()
        {
          var tmp1253 = new get_args();
          if((Req != null) && __isset.req)
          {
            tmp1253.Req = (global::Nebula.Storage.KVGetRequest)this.Req.DeepCopy();
          }
          tmp1253.__isset.req = this.__isset.req;
          return tmp1253;
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
                    Req = new global::Nebula.Storage.KVGetRequest();
                    await Req.ReadAsync(iprot, cancellationToken);
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
            var tmp1254 = new TStruct("get_args");
            await oprot.WriteStructBeginAsync(tmp1254, cancellationToken);
            var tmp1255 = new TField();
            if((Req != null) && __isset.req)
            {
              tmp1255.Name = "req";
              tmp1255.Type = TType.Struct;
              tmp1255.ID = 1;
              await oprot.WriteFieldBeginAsync(tmp1255, cancellationToken);
              await Req.WriteAsync(oprot, cancellationToken);
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
          if (!(that is get_args other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.req == other.__isset.req) && ((!__isset.req) || (System.Object.Equals(Req, other.Req))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Req != null) && __isset.req)
            {
              hashcode = (hashcode * 397) + Req.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1256 = new StringBuilder("get_args(");
          int tmp1257 = 0;
          if((Req != null) && __isset.req)
          {
            if(0 < tmp1257++) { tmp1256.Append(", "); }
            tmp1256.Append("Req: ");
            Req.ToString(tmp1256);
          }
          tmp1256.Append(')');
          return tmp1256.ToString();
        }
      }


      public partial class get_result : TBase
      {
        private global::Nebula.Storage.KVGetResponse _success;

        public global::Nebula.Storage.KVGetResponse Success
        {
          get
          {
            return _success;
          }
          set
          {
            __isset.success = true;
            this._success = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool success;
        }

        public get_result()
        {
        }

        public get_result DeepCopy()
        {
          var tmp1258 = new get_result();
          if((Success != null) && __isset.success)
          {
            tmp1258.Success = (global::Nebula.Storage.KVGetResponse)this.Success.DeepCopy();
          }
          tmp1258.__isset.success = this.__isset.success;
          return tmp1258;
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
                case 0:
                  if (field.Type == TType.Struct)
                  {
                    Success = new global::Nebula.Storage.KVGetResponse();
                    await Success.ReadAsync(iprot, cancellationToken);
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
            var tmp1259 = new TStruct("get_result");
            await oprot.WriteStructBeginAsync(tmp1259, cancellationToken);
            var tmp1260 = new TField();

            if(this.__isset.success)
            {
              if (Success != null)
              {
                tmp1260.Name = "Success";
                tmp1260.Type = TType.Struct;
                tmp1260.ID = 0;
                await oprot.WriteFieldBeginAsync(tmp1260, cancellationToken);
                await Success.WriteAsync(oprot, cancellationToken);
                await oprot.WriteFieldEndAsync(cancellationToken);
              }
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
          if (!(that is get_result other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.success == other.__isset.success) && ((!__isset.success) || (System.Object.Equals(Success, other.Success))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Success != null) && __isset.success)
            {
              hashcode = (hashcode * 397) + Success.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1261 = new StringBuilder("get_result(");
          int tmp1262 = 0;
          if((Success != null) && __isset.success)
          {
            if(0 < tmp1262++) { tmp1261.Append(", "); }
            tmp1261.Append("Success: ");
            Success.ToString(tmp1261);
          }
          tmp1261.Append(')');
          return tmp1261.ToString();
        }
      }


      public partial class put_args : TBase
      {
        private global::Nebula.Storage.KVPutRequest _req;

        public global::Nebula.Storage.KVPutRequest Req
        {
          get
          {
            return _req;
          }
          set
          {
            __isset.req = true;
            this._req = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool req;
        }

        public put_args()
        {
        }

        public put_args DeepCopy()
        {
          var tmp1263 = new put_args();
          if((Req != null) && __isset.req)
          {
            tmp1263.Req = (global::Nebula.Storage.KVPutRequest)this.Req.DeepCopy();
          }
          tmp1263.__isset.req = this.__isset.req;
          return tmp1263;
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
                    Req = new global::Nebula.Storage.KVPutRequest();
                    await Req.ReadAsync(iprot, cancellationToken);
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
            var tmp1264 = new TStruct("put_args");
            await oprot.WriteStructBeginAsync(tmp1264, cancellationToken);
            var tmp1265 = new TField();
            if((Req != null) && __isset.req)
            {
              tmp1265.Name = "req";
              tmp1265.Type = TType.Struct;
              tmp1265.ID = 1;
              await oprot.WriteFieldBeginAsync(tmp1265, cancellationToken);
              await Req.WriteAsync(oprot, cancellationToken);
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
          if (!(that is put_args other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.req == other.__isset.req) && ((!__isset.req) || (System.Object.Equals(Req, other.Req))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Req != null) && __isset.req)
            {
              hashcode = (hashcode * 397) + Req.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1266 = new StringBuilder("put_args(");
          int tmp1267 = 0;
          if((Req != null) && __isset.req)
          {
            if(0 < tmp1267++) { tmp1266.Append(", "); }
            tmp1266.Append("Req: ");
            Req.ToString(tmp1266);
          }
          tmp1266.Append(')');
          return tmp1266.ToString();
        }
      }


      public partial class put_result : TBase
      {
        private global::Nebula.Storage.ExecResponse _success;

        public global::Nebula.Storage.ExecResponse Success
        {
          get
          {
            return _success;
          }
          set
          {
            __isset.success = true;
            this._success = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool success;
        }

        public put_result()
        {
        }

        public put_result DeepCopy()
        {
          var tmp1268 = new put_result();
          if((Success != null) && __isset.success)
          {
            tmp1268.Success = (global::Nebula.Storage.ExecResponse)this.Success.DeepCopy();
          }
          tmp1268.__isset.success = this.__isset.success;
          return tmp1268;
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
                case 0:
                  if (field.Type == TType.Struct)
                  {
                    Success = new global::Nebula.Storage.ExecResponse();
                    await Success.ReadAsync(iprot, cancellationToken);
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
            var tmp1269 = new TStruct("put_result");
            await oprot.WriteStructBeginAsync(tmp1269, cancellationToken);
            var tmp1270 = new TField();

            if(this.__isset.success)
            {
              if (Success != null)
              {
                tmp1270.Name = "Success";
                tmp1270.Type = TType.Struct;
                tmp1270.ID = 0;
                await oprot.WriteFieldBeginAsync(tmp1270, cancellationToken);
                await Success.WriteAsync(oprot, cancellationToken);
                await oprot.WriteFieldEndAsync(cancellationToken);
              }
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
          if (!(that is put_result other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.success == other.__isset.success) && ((!__isset.success) || (System.Object.Equals(Success, other.Success))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Success != null) && __isset.success)
            {
              hashcode = (hashcode * 397) + Success.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1271 = new StringBuilder("put_result(");
          int tmp1272 = 0;
          if((Success != null) && __isset.success)
          {
            if(0 < tmp1272++) { tmp1271.Append(", "); }
            tmp1271.Append("Success: ");
            Success.ToString(tmp1271);
          }
          tmp1271.Append(')');
          return tmp1271.ToString();
        }
      }


      public partial class remove_args : TBase
      {
        private global::Nebula.Storage.KVRemoveRequest _req;

        public global::Nebula.Storage.KVRemoveRequest Req
        {
          get
          {
            return _req;
          }
          set
          {
            __isset.req = true;
            this._req = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool req;
        }

        public remove_args()
        {
        }

        public remove_args DeepCopy()
        {
          var tmp1273 = new remove_args();
          if((Req != null) && __isset.req)
          {
            tmp1273.Req = (global::Nebula.Storage.KVRemoveRequest)this.Req.DeepCopy();
          }
          tmp1273.__isset.req = this.__isset.req;
          return tmp1273;
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
                    Req = new global::Nebula.Storage.KVRemoveRequest();
                    await Req.ReadAsync(iprot, cancellationToken);
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
            var tmp1274 = new TStruct("remove_args");
            await oprot.WriteStructBeginAsync(tmp1274, cancellationToken);
            var tmp1275 = new TField();
            if((Req != null) && __isset.req)
            {
              tmp1275.Name = "req";
              tmp1275.Type = TType.Struct;
              tmp1275.ID = 1;
              await oprot.WriteFieldBeginAsync(tmp1275, cancellationToken);
              await Req.WriteAsync(oprot, cancellationToken);
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
          if (!(that is remove_args other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.req == other.__isset.req) && ((!__isset.req) || (System.Object.Equals(Req, other.Req))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Req != null) && __isset.req)
            {
              hashcode = (hashcode * 397) + Req.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1276 = new StringBuilder("remove_args(");
          int tmp1277 = 0;
          if((Req != null) && __isset.req)
          {
            if(0 < tmp1277++) { tmp1276.Append(", "); }
            tmp1276.Append("Req: ");
            Req.ToString(tmp1276);
          }
          tmp1276.Append(')');
          return tmp1276.ToString();
        }
      }


      public partial class remove_result : TBase
      {
        private global::Nebula.Storage.ExecResponse _success;

        public global::Nebula.Storage.ExecResponse Success
        {
          get
          {
            return _success;
          }
          set
          {
            __isset.success = true;
            this._success = value;
          }
        }


        public Isset __isset;
        public struct Isset
        {
          public bool success;
        }

        public remove_result()
        {
        }

        public remove_result DeepCopy()
        {
          var tmp1278 = new remove_result();
          if((Success != null) && __isset.success)
          {
            tmp1278.Success = (global::Nebula.Storage.ExecResponse)this.Success.DeepCopy();
          }
          tmp1278.__isset.success = this.__isset.success;
          return tmp1278;
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
                case 0:
                  if (field.Type == TType.Struct)
                  {
                    Success = new global::Nebula.Storage.ExecResponse();
                    await Success.ReadAsync(iprot, cancellationToken);
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
            var tmp1279 = new TStruct("remove_result");
            await oprot.WriteStructBeginAsync(tmp1279, cancellationToken);
            var tmp1280 = new TField();

            if(this.__isset.success)
            {
              if (Success != null)
              {
                tmp1280.Name = "Success";
                tmp1280.Type = TType.Struct;
                tmp1280.ID = 0;
                await oprot.WriteFieldBeginAsync(tmp1280, cancellationToken);
                await Success.WriteAsync(oprot, cancellationToken);
                await oprot.WriteFieldEndAsync(cancellationToken);
              }
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
          if (!(that is remove_result other)) return false;
          if (ReferenceEquals(this, other)) return true;
          return ((__isset.success == other.__isset.success) && ((!__isset.success) || (System.Object.Equals(Success, other.Success))));
        }

        public override int GetHashCode() {
          int hashcode = 157;
          unchecked {
            if((Success != null) && __isset.success)
            {
              hashcode = (hashcode * 397) + Success.GetHashCode();
            }
          }
          return hashcode;
        }

        public override string ToString()
        {
          var tmp1281 = new StringBuilder("remove_result(");
          int tmp1282 = 0;
          if((Success != null) && __isset.success)
          {
            if(0 < tmp1282++) { tmp1281.Append(", "); }
            tmp1281.Append("Success: ");
            Success.ToString(tmp1281);
          }
          tmp1281.Append(')');
          return tmp1281.ToString();
        }
      }

    }

  }
}