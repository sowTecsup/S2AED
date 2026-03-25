using System.Collections.Generic;
using UnityEngine;
using Sowtank.Utils;

public class GameManager : MonoBehaviour
{
    private Inventory<string> inventory = new();
    private Inventory<int> inventory2 = new();
    private Player player;

    void Start()
    {
        GameUtils.Process<string>
            ("12", x => Debug.Log(x));

        GameUtils.Process<Player>(player, x => x.Move());
    }
}
