using System.Collections.Generic;

namespace quiz;

public static class GenericsList<T>
{
  public static List<T> Items { get; } = new List<T>();
}