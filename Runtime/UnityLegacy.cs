#define DEBUG
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnityLegacy
{

    public static Transform[] GetAllChildrenArray(this Transform transform)
    {
        int childCount = transform.childCount;
        Transform[] result = new Transform[childCount];
        for (int i = 0; i < childCount; i++)
        {
            result[i] = transform.GetChild(i);
        }
        return result;
    }
    public static List<Transform> GetAllChildrenList(this Transform transform)
    {
        List<Transform> result = new List<Transform>();
        foreach (Transform child in transform)
        {
            result.Add(child);
        }
        return result;
    }

    public static float InputHorizontal() => Input.GetAxis("Horizontal");
    public static float InputVertical() => Input.GetAxis("Vertical");
    public static bool InputJump() => Input.GetKeyDown(KeyCode.Space);
}

