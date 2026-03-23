using Sowtank.GameUtils;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        GameUtils.Process("Hello, World!", message => Debug.Log(message));


        GameUtils.Process("Hello, World!", x => Debug.Log(x));

        GameUtils.Process<string,string>("Hello, World!", "asdasda", (x,y) => Debug.Log(x + " " + y));


        GameUtils.Process<string>("Hello, World!", x => Debug.Log(x));



        GameUtils.Process("Hello, World!", message => 
                                                        { 
                                                            Debug.Log(message);
                                                        });
        List<int> numeros = new List<int> { 1, 2, 3, 4 };

        // numeros.ForEach

      //  InflictDamageClass.ApplyDamage(24);
    }

    void Update()
    {
        
    }
}
