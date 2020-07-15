using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ExtensionMethodsSample
{
    static class StringExtensions
    {
        public static void Foo(this string s, int x)
        {
            Console.WriteLine($"Foo {s} {x}");
        }

       //  public static int MyABC(this string s) { get; set; }
    }


    static class CollectionExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> pred)
        {
            foreach (T item in source)
            {
                if (pred(item))
                {
                    yield return item;
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string s = "sample";
            s.Foo(42);

            s.MyABC = 3;

            StringExtensions.Foo(s, 42);

            string[] data = { "James", "Jochen", "Niki", "Juan" };

            var q = from n in data
                    where n.StartsWith("J")
                    select n;
            

            foreach (var name in q)
            {
                Console.WriteLine(name);
            }


            //var result = data.Filter(
            //    s => s.StartsWith("J"));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result2 = data.Where(n => n.StartsWith("J"));
    

        }
    }
}
