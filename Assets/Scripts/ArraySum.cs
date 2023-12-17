using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Write a function that takes an array of numbers and returns the sum of the numbers. 
The numbers can be negative or non-integer. 
If the array does not contain any numbers then you should return 0.
Tasks URL: https://www.codewars.com/kata/53dc54212259ed3d4f00071c/train/csharp
 */

public class ArraySum : MonoBehaviour
{
    [SerializeField]
    double[] myArray = { 1, 5.2, 4, 0, -1 };

    [ContextMenu("Array summ")]
    void ArraySumm()
    {
        double summ = 0;
        if (myArray == null)
        {
            Debug.Log(0);
        }
        else
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                summ = summ + myArray[i];
            }
            Debug.Log(summ);
        }
       
        
    }
}
