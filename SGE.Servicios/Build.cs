﻿using System;
using System.Collections.Generic;

namespace Builder
{
    public class Build
    {
        private static readonly Dictionary<string, Func<object>> defaults = new Dictionary<string, Func<object>>
            {
                // define your builders here!
                // {TypeKey<Person>(), () => new Person()},
                // {"SomeCustomBuilder", () => new Person("John")}
            };

        public static T A<T>()
        {
            return A<T>(TypeKey<T>());
        }
        
        public static T A<T>(string key)
        {
            if (!defaults.ContainsKey(key)) throw new ArgumentException("No object of type " + key + " has been configured with the builder.");
            return (T)defaults[key]();
        }

        public static T A<T>(Action<T> customisation)
        {
            return A<T>(TypeKey<T>(), customisation);
        }

        public static T A<T>(string key, Action<T> customisation)
        {
            T o = A<T>(key);
            customisation(o);
            return o;
        }

        // aliases

        public static T An<T>()
        {
            return A<T>();
        }
        
        public static T An<T>(string key)
        {
            return A<T>(key);
        }

        public static T An<T>(Action<T> customisation)
        {
            return A<T>(customisation);
        }
        
        public static T An<T>(string key, Action<T> customisation)
        {
            return A<T>(key, customisation);
        }

        private static string TypeKey<T>()
        {
            return typeof(T).FullName;
        }
    }
}
