using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

/* 
Given a random non-negative number, you have to return the digits of this number within an array in reverse order.
Task URL: https://www.codewars.com/kata/5583090cbe83f4fd8c000051/train/csharp
 */
public class FromStringToReversArray : MonoBehaviour
{
    [SerializeField]
    string stringNum = "1234567";

    [ContextMenu("From string to Reverse Array")]
    void FromStringToReverseArray()
    {
        int[] numbers = new int[stringNum.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            int reverseIndex = numbers.Length - 1 - i;
            numbers[i] = int.Parse(stringNum[reverseIndex].ToString());
        }

        foreach (int number in numbers)
        {
            Debug.Log(number + " ");
        }
    }
}
