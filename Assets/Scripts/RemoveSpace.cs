using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Write a function that removes the spaces from the string, then return the resultant string.
Task URL: https://www.codewars.com/kata/57eae20f5500ad98e50002c5/train/csharp
 */
public class RemoveSpace : MonoBehaviour
{
    [SerializeField]
    string stringWithSpace = "fjdojgdg dgokdo  gmdo g g  g gdg gpdgkd";

    [ContextMenu("Remove Space")]
    void SpaceRemove()
    {
        string nonSpace = stringWithSpace.Replace(" ", "");
        Debug.Log(nonSpace);
    }
}
