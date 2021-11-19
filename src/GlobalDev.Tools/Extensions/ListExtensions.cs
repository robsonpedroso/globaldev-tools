using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalDev.Tools.Extensions
{
    /// <summary>
    /// Helper methods for the lists.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Breaks the list into smaller pieces  
        /// </summary>
        /// <typeparam name="T">Type of list objects</typeparam>
        /// <param name="source">List of objects to be split</param>
        /// <param name="chunkSize">Desired quantity for dividing blocks</param>
        /// <returns>Array with blocks divided with desired quantities</returns>
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}
