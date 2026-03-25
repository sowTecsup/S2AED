
using System.Collections.Generic;
using UnityEngine;


public class Inventory<T>
{
    private List<T> inventory = new();

    public void AddItem(T item)
    {
        inventory.Add(item);
        Debug.Log("You just add " + item);

    }
}
