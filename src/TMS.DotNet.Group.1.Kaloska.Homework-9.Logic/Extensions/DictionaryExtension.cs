using System;
using System.Collections.Generic;
using System.Linq;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Extensions
{
    public static class DictionaryExtension
    {
        public static string ConvertToQueryString(this Dictionary<string, string> dictionary) =>
            dictionary.Aggregate(string.Empty,
                (current, keyValuePair) => current + $"{Uri.EscapeDataString(keyValuePair.Key)}={Uri.EscapeDataString(keyValuePair.Value ?? string.Empty)}&").TrimEnd('&');
    }
}
