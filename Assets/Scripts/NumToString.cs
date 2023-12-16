using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NumToString : MonoBehaviour
{
    public int X = 0;
    [ContextMenu("NumToString")]
    void numToString()
    {
        string s = X.ToString();
        Debug.Log(s);
        Debug.Log(s.GetType());
    }
}
