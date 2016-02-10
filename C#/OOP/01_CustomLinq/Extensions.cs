using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CustomLinq
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            var newList = new List<T>();

            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    newList.Add(element);
                }
            }

            return newList;
        }

        public static K Maxxx<T, K>(this IEnumerable<T> collection, Func<T, K> something)
            where K : IComparable
        {

            if (collection == null)
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            K max = something(collection.First());
            foreach (var element in collection)
            {
                K current = something(element);
                if (current.CompareTo(max) == 1)
                {
                    max = current;
                }
            }
            return max;
        }
    }
}
