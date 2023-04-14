using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory<T>
{
    Inventory<string> _inventory = new Inventory<string>();

    private T[] _item = new T[10];
    public void AddOrUpdate(int index, T item)
    {
        if (index >= 0 && index < 10)
            _item[index] = item;
    }

    public T GetData(int index)
    {
        if (index >= 0 && index < 10)
        {
            return _item[index];
        }
        else
        {
            return default(T);
        }
    }


}
