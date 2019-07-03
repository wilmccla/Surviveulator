using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public delegate void OnItemChanged();

    public OnItemChanged onItemChangedCallBack;

    public static Inventory instance;

    public List<Item> items = new List<Item>();

    public int space = 20;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one instance of inventory");
            return;
        }

        instance = this;
    }

    public bool Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Inventory is full");
                return false;
            }
            items.Add(item);

            if (onItemChangedCallBack != null)
            {
                onItemChangedCallBack.Invoke();
            }
        }

        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);

        if (onItemChangedCallBack != null)
        {
            onItemChangedCallBack.Invoke();
        }
    }
}
