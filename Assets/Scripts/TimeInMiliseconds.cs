using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Clock shows hours, minutes and seconds after midnight.hms
//Your task is to write a function which returns the time since midnight in milliseconds.
// Task Link: https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a/train/csharp
public class TimeInMiliseconds : MonoBehaviour
{
    [SerializeField] int h;
    [SerializeField] int m;
    [SerializeField] int s;

    [ContextMenu("Convert Time")]
    public void ConvetrTime()
    {
        int result = 0;
        result = result + h * 60 * 60 * 1000 + m * 60 * 1000 + s * 1000;

        Debug.Log(result);
    }
}
