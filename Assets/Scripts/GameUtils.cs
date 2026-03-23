using System;
using UnityEngine;

namespace Sowtank.GameUtils
{
    public class GameUtils
    {
        public static void Process<T>(T element, Action<T> action)
        {
            action(element);
        }
        public static void Process<T1,T2>(T1 element1,T2 element2, Action<T1,T2> action)
        {
            action(element1,element2);
        }
        public static TResult Transform<T, TResult>(T input, Func<T, TResult> func)
        {
            return func(input);
            
        }

    }
}
