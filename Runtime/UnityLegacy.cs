#define DEBUG
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnityLegacy
{
    public static float InputHorizontal() => Input.GetAxis("Horizontal");
    public static float InputVertical() => Input.GetAxis("Vertical");
}

