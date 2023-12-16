using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CheckPalindome : MonoBehaviour
{
    public int X = 0;
    [ContextMenu("Check Palindrome")]
    void CheckPalindrome()
    {
        int x = X;
        string numAsString = x.ToString();
        string reverse = new string(numAsString.Reverse().ToArray());
        bool result = reverse == numAsString;
        Debug.Log(result);
    }
}

