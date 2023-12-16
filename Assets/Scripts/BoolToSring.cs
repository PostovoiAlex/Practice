using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Implement a function which convert the given boolean value into its string representation.
Note: Only valid inputs will be given.
Tasks URL: https://www.codewars.com/kata/551b4501ac0447318f0009cd/train/csharp
*/

public class BoolToSring : MonoBehaviour
{

   public bool VALUE = false;
   [ContextMenu("Bool to string")]
   void boolToString()
   {
       Debug.Log(VALUE.ToString());
   }
}
