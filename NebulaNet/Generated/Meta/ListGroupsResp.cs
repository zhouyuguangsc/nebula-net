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

  public partial class ListGroupsResp : TBase
  {
    private global::Nebula.Common.ErrorCode _code;
    private global::Nebula.Common.HostAddr _leader;
    private List<global::Nebula.Meta.@Group> _groups;

    /// <summary>
    /// 
    /// <seealso cref="global::Nebula.Common.ErrorCode"/>
    /// </summary>
    public global::Nebula.Common.ErrorCode Code
    {
      get
      {
        return _code;
      }
      set
      {
        __isset.code = true;
        this._code = value;
      }
    }

    public global::Nebula.Common.HostAddr Leader
    {
      get
      {
        return _leader;
      }
      set
      {
        __isset.leader = true;
        this._leader = value;
      }
    }

    public List<global::Nebula.Meta.@Group> Groups
    {
      get
      {
        return _groups;
      }
      set
      {
        __isset.groups = true;
        this._groups = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool code;
      public bool leader;
      public bool groups;
    }

    public ListGroupsResp()
    {
    }

    public ListGroupsResp DeepCopy()
    {
      var tmp843 = new ListGroupsResp();
      if(__isset.code)
      {
        tmp843.Code = this.Code;
      }
      tmp843.__isset.code = this.__isset.code;
      if((Leader != null) && __isset.leader)
      {
        tmp843.Leader = (global::Nebula.Common.HostAddr)this.Leader.DeepCopy();
      }
      tmp843.__isset.leader = this.__isset.leader;
      if((Groups != null) && __isset.groups)
      {
        tmp843.Groups = this.Groups.DeepCopy();
      }
      tmp843.__isset.groups = this.__isset.groups;
      return tmp843;
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
                Code = (global::Nebula.Common.ErrorCode)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Leader = new global::Nebula.Common.HostAddr();
                await Leader.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.List)
              {
                {
                  TList _list844 = await iprot.ReadListBeginAsync(cancellationToken);
                  Groups = new List<global::Nebula.Meta.@Group>(_list844.Count);
                  for(int _i845 = 0; _i845 < _list844.Count; ++_i845)
                  {
                    global::Nebula.Meta.@Group _elem846;
                    _elem846 = new global::Nebula.Meta.@Group();
                    await _elem846.ReadAsync(iprot, cancellationToken);
                    Groups.Add(_elem846);
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
        var tmp847 = new TStruct("ListGroupsResp");
        await oprot.WriteStructBeginAsync(tmp847, cancellationToken);
        var tmp848 = new TField();
        if(__isset.code)
        {
          tmp848.Name = "code";
          tmp848.Type = TType.I32;
          tmp848.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp848, cancellationToken);
          await oprot.WriteI32Async((int)Code, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Leader != null) && __isset.leader)
        {
          tmp848.Name = "leader";
          tmp848.Type = TType.Struct;
          tmp848.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp848, cancellationToken);
          await Leader.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Groups != null) && __isset.groups)
        {
          tmp848.Name = "groups";
          tmp848.Type = TType.List;
          tmp848.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp848, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Groups.Count), cancellationToken);
            foreach (global::Nebula.Meta.@Group _iter849 in Groups)
            {
              await _iter849.WriteAsync(oprot, cancellationToken);
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
      if (!(that is ListGroupsResp other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.code == other.__isset.code) && ((!__isset.code) || (System.Object.Equals(Code, other.Code))))
        && ((__isset.leader == other.__isset.leader) && ((!__isset.leader) || (System.Object.Equals(Leader, other.Leader))))
        && ((__isset.groups == other.__isset.groups) && ((!__isset.groups) || (TCollections.Equals(Groups, other.Groups))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.code)
        {
          hashcode = (hashcode * 397) + Code.GetHashCode();
        }
        if((Leader != null) && __isset.leader)
        {
          hashcode = (hashcode * 397) + Leader.GetHashCode();
        }
        if((Groups != null) && __isset.groups)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Groups);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp850 = new StringBuilder("ListGroupsResp(");
      int tmp851 = 0;
      if(__isset.code)
      {
        if(0 < tmp851++) { tmp850.Append(", "); }
        tmp850.Append("Code: ");
        Code.ToString(tmp850);
      }
      if((Leader != null) && __isset.leader)
      {
        if(0 < tmp851++) { tmp850.Append(", "); }
        tmp850.Append("Leader: ");
        Leader.ToString(tmp850);
      }
      if((Groups != null) && __isset.groups)
      {
        if(0 < tmp851++) { tmp850.Append(", "); }
        tmp850.Append("Groups: ");
        Groups.ToString(tmp850);
      }
      tmp850.Append(')');
      return tmp850.ToString();
    }
  }

}