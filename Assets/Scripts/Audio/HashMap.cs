using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashMap<Key, Value>
{
    private Hashtable hashTable;

    public HashMap()
    {
        hashTable = new Hashtable();
    }
    
    public void Add(Key key, Value value)
    {
        hashTable.Add(key, value);
    }

    public Value GetValue(Key key)
    {
        return (Value)hashTable[key];
    }
}
