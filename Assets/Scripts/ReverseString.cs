using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Complete the solution so that it reverses the string passed into it.
// Task Link: 

public class ReverseString : MonoBehaviour
{
    [SerializeField] string _word;

    [ContextMenu("Reverse string")]
    public string Reverse()
    {
        char[] WordToArray = _word.ToCharArray();
        WordToArray = WordToArray.Reverse().ToArray();
        string ReversedWord = new string(WordToArray);
        Debug.Log(ReversedWord);
        return ReversedWord;
 
    }

}

