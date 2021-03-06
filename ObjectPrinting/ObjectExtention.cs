﻿using System;

namespace ObjectPrinting
{
    public static class ObjectExtensions
    {
        public static string PrintToString<T>(this T obj)
        {
            return ObjectPrinter.For<T>().PrintToString(obj);
        }

        public static string PrintToString<T>(this T obj, Func<string, string> func)
        {
            return func(ObjectPrinter.For<T>().PrintToString(obj));
        }

    }
}