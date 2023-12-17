using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Define a method hello that returns "Hello, Name!" to a given name, or says Hello, World! if name is not given (or passed as an empty String).
//Assuming that name is a String and it checks for user typos to return a name with a first capital letter (Xxxx).
//Task Link: https://www.codewars.com/kata/57e3f79c9cb119374600046b/train/csharp

public class HelloNameOrWorld : MonoBehaviour
{
    [SerializeField] string _name;
    [ContextMenu("Hello World or Name")]
    public void Hello() 
    {
        if (string.IsNullOrEmpty(_name))
        {
            Debug.Log("Hello, World!");
        
        }
        else 
        {
            Debug.Log($"Hello, {_name[0].ToString().ToUpper() + _name[1..].ToLower()}");
        }
    }
}
