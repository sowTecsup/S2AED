using UnityEngine;
using System.Collections;

public class InflictDamageClass
{

   public static void ApplyDamage<T>(T target) where T : IDamageable
    {
        target.TakeDamage(10);
    }
}
