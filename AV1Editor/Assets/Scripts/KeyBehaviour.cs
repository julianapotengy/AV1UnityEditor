using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    [System.Serializable]
    public class Entry
    {
        public string key = "Key";
        public int value;
    }

    public List<Entry> listEntry = new List<Entry>();
}
