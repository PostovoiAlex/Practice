using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
We need a function that can transform a string into a number
Task URL: https://www.codewars.com/kata/544675c6f971f7399a000e79/train/csharp
*/
public class StringToNum : MonoBehaviour
{
    [SerializeField]
    string numstring = "0";

    [ContextMenu("From string to num")]
    void FromStringToNum()
    {
        int number = int.Parse(numstring);
        Debug.Log(number.GetType());
    }
}
