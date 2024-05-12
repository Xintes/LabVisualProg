namespace Lab9VisualProg
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CollectionExtensions
    {
        // Проверка, удовлетворяют ли все элементы условию (предикату)
        public static bool MyAll<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
{
    foreach (var item in source)
    {
        if (!predicate(item))
        {
            return false;
        }
    }
    return true;
}



        // Возвращает коллекцию элементов, которых нет в обеих коллекциях
        public static IEnumerable<TSource> MyIntersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            var firstSet = new HashSet<TSource>(first);
            var secondSet = new HashSet<TSource>(second);
            // Возвращаем элементы, которые присутствуют только в одной коллекции
            foreach (var item in firstSet)
            {
                if (!secondSet.Contains(item))
                {
                    yield return item;
                }
            }
            foreach (var item in secondSet)
            {
                if (!firstSet.Contains(item))
                {
                    yield return item;
                }
            }
        }

        // Применяет функцию ко всем элементам коллекции и возвращает коллекцию с результатами
        public static IEnumerable<TResult> MyDoThing<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> thing )
        {
            var result = new List<TResult>();

            foreach (var item in source)
                result.Add(thing(item));

            return result;
        }

        // Исключает повторяющиеся элементы с одним ключом
        public static IEnumerable<TSource> MyDistinct<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keyExtractor)
        {
            var uniqueKeys = new HashSet<TKey>();

            foreach (var item in source)
            {
                var key = keyExtractor(item);
                if (uniqueKeys.Add(key))
                {
                    yield return item;
                }
            }
        }

        // Возвращает словарь из переданной коллекции

        public static Dictionary<TKey, List<TValue>> MyToDictionary<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> keyExtractor, int n)
    where TKey : notnull
        {
            //Dictionary<TKey, List<TValue>> dictionary = new Dictionary<TKey, List<TValue>>();

            //foreach (TValue item in source)
            //{
            //    TKey key = keyExtractor(item);
            //    if (!dictionary.ContainsKey(key))
            //    {
            //        dictionary[key] = new List<TValue>();
            //    }
            //    dictionary[key].Add(item);
            //}

            //// Фильтрация слов, начинающихся с первых n букв
            //var filteredDictionary = dictionary.Where(kv => {
            //    string? stringKey = kv.Key?.ToString(); // Добавлено "?"
            //    string? stringValue = keyExtractor(kv.Value[0])?.ToString(); // Добавлено "?"

            //    bool keyContainsNChars = stringKey?.Length >= n; // Добавлено "?"

            //    bool valueStartsFomNChars = stringKey?.Substring(0, n) == stringValue; // Добавлено "?"
            //    return keyContainsNChars && valueStartsFomNChars;
            //})
            //    .ToDictionary(kv => kv.Key, kv => kv.Value);

            //return filteredDictionary;


            var filteredDictionary =
         (
             from item in source
             let key = keyExtractor(item)
             group item by key into grouped
             let stringKey = grouped.Key?.ToString()
             let stringValue = keyExtractor(grouped.First())?.ToString()
             where stringKey?.Length >= n && stringKey?.Substring(0, n) == stringValue
             select new { Key = grouped.Key, Values = grouped.ToList() }
         ).ToDictionary(x => x.Key, x => x.Values);

            return filteredDictionary;


        }


    }
}


//На защ
//Dictionary<TKey, List<TValue>>
//В этом словаре найти слова, начинающиеся на превые n букв

//CS 8714
//Написать в виде query
