using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class DebugLegacy
{
    public static string WithColor(this string String, string color)
    {
        return $"<color={color}>{String}</color>";
    }

    public static void DebugDrawLine(Vector3 p1, Vector3 p2, Color color, float width)
    {
        int count = 1 + Mathf.CeilToInt(width); // how many lines are needed.
        if (count == 1)
        {
            Debug.DrawLine(p1, p2, color, Time.deltaTime);
        }
        else
        {
            Camera c = Camera.main;
            if (c == null)
            {
                Debug.LogError("Camera.main is null");
                return;
            }
            var scp1 = c.WorldToScreenPoint(p1);
            var scp2 = c.WorldToScreenPoint(p2);


            Vector3 direction = (scp2 - scp1).normalized; // line direction
            Vector3 normal = Vector3.Cross(direction, Vector3.forward); // normal vector

            for (int i = 0; i < count; i++)
            {
                Vector3 o = 0.99f * normal * width * ((float)i / (count - 1) - 0.5f);
                Vector3 origin = c.ScreenToWorldPoint(scp1 + o);
                Vector3 destiny = c.ScreenToWorldPoint(scp2 + o);
                Debug.DrawLine(origin, destiny, color, Time.deltaTime);
            }
        }
    }
}
