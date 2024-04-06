namespace Lab9VisualProg
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CollectionExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            return collection.Where(condition);
        }

        public static IEnumerable<TResult> Map<T, TResult>(this IEnumerable<T> collection, Func<T, TResult> transform)
        {
            return collection.Select(transform);
        }

        public static T Reduce<T>(this IEnumerable<T> collection, Func<T, T, T> accumulator)
        {
            return collection.Aggregate(accumulator);
        }

        public static IEnumerable<T> SortBy<T, TKey>(this IEnumerable<T> collection, Func<T, TKey> keySelector)
        {
            return collection.OrderBy(keySelector);
        }

        public static Dictionary<TKey, List<T>> GroupByCount<T, TKey>(this IEnumerable<T> collection, Func<T, TKey> keySelector)
        {
            return collection.GroupBy(keySelector).ToDictionary(g => g.Key, g => g.ToList());
        }

    }
}
