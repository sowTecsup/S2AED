using System;
using UnityEngine;

//namespace Fortnite.Core
//namespace Fortnite.VFX
//namespace Fortnite.Database
//namespace Fortnite.Weapons

namespace Sowtank.Utils
{
    public class GameUtils
    {
        public static void Process<T>(T element , Action<T> action)
        {
            action(element); 
        }
    }
}
