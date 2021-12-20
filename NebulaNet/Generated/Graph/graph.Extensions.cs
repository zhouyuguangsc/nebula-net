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


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Nebula.Graph
{
  public static class graphExtensions
  {
    public static bool Equals(this Dictionary<byte[], byte[]> instance, object that)
    {
      if (!(that is Dictionary<byte[], byte[]> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<byte[], byte[]> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<byte[], byte[]> DeepCopy(this Dictionary<byte[], byte[]> source)
    {
      if (source == null)
        return null;

      var tmp157 = new Dictionary<byte[], byte[]>(source.Count);
      foreach (var pair in source)
        tmp157.Add((pair.Key != null) ? pair.Key.ToArray() : null, (pair.Value != null) ? pair.Value.ToArray() : null);
      return tmp157;
    }


    public static bool Equals(this Dictionary<byte[], global::Nebula.Common.@Value> instance, object that)
    {
      if (!(that is Dictionary<byte[], global::Nebula.Common.@Value> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<byte[], global::Nebula.Common.@Value> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<byte[], global::Nebula.Common.@Value> DeepCopy(this Dictionary<byte[], global::Nebula.Common.@Value> source)
    {
      if (source == null)
        return null;

      var tmp158 = new Dictionary<byte[], global::Nebula.Common.@Value>(source.Count);
      foreach (var pair in source)
        tmp158.Add((pair.Key != null) ? pair.Key.ToArray() : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
      return tmp158;
    }


    public static bool Equals(this Dictionary<long, long> instance, object that)
    {
      if (!(that is Dictionary<long, long> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<long, long> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<long, long> DeepCopy(this Dictionary<long, long> source)
    {
      if (source == null)
        return null;

      var tmp159 = new Dictionary<long, long>(source.Count);
      foreach (var pair in source)
        tmp159.Add(pair.Key, pair.Value);
      return tmp159;
    }


    public static bool Equals(this List<List<global::Nebula.Common.Coordinate>> instance, object that)
    {
      if (!(that is List<List<global::Nebula.Common.Coordinate>> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<List<global::Nebula.Common.Coordinate>> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<List<global::Nebula.Common.Coordinate>> DeepCopy(this List<List<global::Nebula.Common.Coordinate>> source)
    {
      if (source == null)
        return null;

      var tmp160 = new List<List<global::Nebula.Common.Coordinate>>(source.Count);
      foreach (var elem in source)
        tmp160.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp160;
    }


    public static bool Equals(this List<byte[]> instance, object that)
    {
      if (!(that is List<byte[]> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<byte[]> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<byte[]> DeepCopy(this List<byte[]> source)
    {
      if (source == null)
        return null;

      var tmp161 = new List<byte[]>(source.Count);
      foreach (var elem in source)
        tmp161.Add((elem != null) ? elem.ToArray() : null);
      return tmp161;
    }


    public static bool Equals(this List<global::Nebula.Common.@Value> instance, object that)
    {
      if (!(that is List<global::Nebula.Common.@Value> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Nebula.Common.@Value> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Nebula.Common.@Value> DeepCopy(this List<global::Nebula.Common.@Value> source)
    {
      if (source == null)
        return null;

      var tmp162 = new List<global::Nebula.Common.@Value>(source.Count);
      foreach (var elem in source)
        tmp162.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp162;
    }


    public static bool Equals(this List<global::Nebula.Common.Coordinate> instance, object that)
    {
      if (!(that is List<global::Nebula.Common.Coordinate> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Nebula.Common.Coordinate> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Nebula.Common.Coordinate> DeepCopy(this List<global::Nebula.Common.Coordinate> source)
    {
      if (source == null)
        return null;

      var tmp163 = new List<global::Nebula.Common.Coordinate>(source.Count);
      foreach (var elem in source)
        tmp163.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp163;
    }


    public static bool Equals(this List<global::Nebula.Common.Row> instance, object that)
    {
      if (!(that is List<global::Nebula.Common.Row> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Nebula.Common.Row> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Nebula.Common.Row> DeepCopy(this List<global::Nebula.Common.Row> source)
    {
      if (source == null)
        return null;

      var tmp164 = new List<global::Nebula.Common.Row>(source.Count);
      foreach (var elem in source)
        tmp164.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp164;
    }


    public static bool Equals(this List<global::Nebula.Common.Step> instance, object that)
    {
      if (!(that is List<global::Nebula.Common.Step> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Nebula.Common.Step> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Nebula.Common.Step> DeepCopy(this List<global::Nebula.Common.Step> source)
    {
      if (source == null)
        return null;

      var tmp165 = new List<global::Nebula.Common.Step>(source.Count);
      foreach (var elem in source)
        tmp165.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp165;
    }


    public static bool Equals(this List<global::Nebula.Common.Tag> instance, object that)
    {
      if (!(that is List<global::Nebula.Common.Tag> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Nebula.Common.Tag> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Nebula.Common.Tag> DeepCopy(this List<global::Nebula.Common.Tag> source)
    {
      if (source == null)
        return null;

      var tmp166 = new List<global::Nebula.Common.Tag>(source.Count);
      foreach (var elem in source)
        tmp166.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp166;
    }


    public static bool Equals(this List<global::Nebula.Graph.Pair> instance, object that)
    {
      if (!(that is List<global::Nebula.Graph.Pair> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Nebula.Graph.Pair> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Nebula.Graph.Pair> DeepCopy(this List<global::Nebula.Graph.Pair> source)
    {
      if (source == null)
        return null;

      var tmp167 = new List<global::Nebula.Graph.Pair>(source.Count);
      foreach (var elem in source)
        tmp167.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp167;
    }


    public static bool Equals(this List<global::Nebula.Graph.PlanNodeDescription> instance, object that)
    {
      if (!(that is List<global::Nebula.Graph.PlanNodeDescription> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Nebula.Graph.PlanNodeDescription> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Nebula.Graph.PlanNodeDescription> DeepCopy(this List<global::Nebula.Graph.PlanNodeDescription> source)
    {
      if (source == null)
        return null;

      var tmp168 = new List<global::Nebula.Graph.PlanNodeDescription>(source.Count);
      foreach (var elem in source)
        tmp168.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp168;
    }


    public static bool Equals(this List<global::Nebula.Graph.ProfilingStats> instance, object that)
    {
      if (!(that is List<global::Nebula.Graph.ProfilingStats> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Nebula.Graph.ProfilingStats> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Nebula.Graph.ProfilingStats> DeepCopy(this List<global::Nebula.Graph.ProfilingStats> source)
    {
      if (source == null)
        return null;

      var tmp169 = new List<global::Nebula.Graph.ProfilingStats>(source.Count);
      foreach (var elem in source)
        tmp169.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp169;
    }


    public static bool Equals(this List<long> instance, object that)
    {
      if (!(that is List<long> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<long> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<long> DeepCopy(this List<long> source)
    {
      if (source == null)
        return null;

      var tmp170 = new List<long>(source.Count);
      foreach (var elem in source)
        tmp170.Add(elem);
      return tmp170;
    }


    public static bool Equals(this THashSet<global::Nebula.Common.@Value> instance, object that)
    {
      if (!(that is THashSet<global::Nebula.Common.@Value> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this THashSet<global::Nebula.Common.@Value> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static THashSet<global::Nebula.Common.@Value> DeepCopy(this THashSet<global::Nebula.Common.@Value> source)
    {
      if (source == null)
        return null;

      var tmp171 = new THashSet<global::Nebula.Common.@Value>(source.Count);
      foreach (var elem in source)
        tmp171.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp171;
    }


  }
}