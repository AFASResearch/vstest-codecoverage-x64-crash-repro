using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
  public static class KeyValuePairParsingExtensions
  {
    /// <summary>
    ///   Gets the first fournd keyvaluepair from the collection, or returns the default
    /// </summary>
    /// <param name="keyValuePairs"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public static KeyValuePair<string, string[]>? GetKeyValuePair(this IEnumerable<KeyValuePair<string, string[]>> keyValuePairs, string key)
    {
      return keyValuePairs.FirstOrDefault(kv => kv.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
    }
  }

  public static class Class1
  {

    public static int Add(int x, int y)
    {
      return x + y;
    }
  }
}
