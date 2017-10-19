using System;
using System.Collections.Generic;
using System.Linq;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        List<T> list = new List<T>();
        foreach(var element in collection)
        {
            //'yield' keyword to return all values of the collection
            //passing through the delegated function 'func'.
            yield return func(element);
        }
    }
}