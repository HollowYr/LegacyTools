#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CoroutineLegacy 
{
    private static IEnumerator DoAfterTime(float duration, Action OnComplete)
    {
        yield return new WaitForSeconds(duration);
        OnComplete?.Invoke();
    }

    public static void DoAfterNextFrame(this MonoBehaviour monoBehaviour, Action onComplete)
    {
        monoBehaviour.StartCoroutine(DoAfterTime(0, onComplete));
    }

    public static void DoAfterTime(this MonoBehaviour monoBehaviour, float waitForTime, Action onComplete)
    {
        monoBehaviour.StartCoroutine(DoAfterTime(waitForTime, onComplete));
    }
}

