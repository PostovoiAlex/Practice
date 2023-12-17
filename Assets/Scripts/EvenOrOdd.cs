using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
Task URL: https://www.codewars.com/kata/53da3dbb4a5168369a0000fe/train/csharp
*/

public class EvenOrOdd : MonoBehaviour
{
    [SerializeField]
    int num = 0;

    [ContextMenu("Odd or Even")]
    void OddOrEven() 
    {
        if (num % 2 == 0) 
        {
            Debug.Log("Even");
        }
        else 
        {
            Debug.Log("Odd");
        }
    }
}
