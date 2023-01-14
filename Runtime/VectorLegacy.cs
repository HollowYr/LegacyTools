#define DEBUG
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorLegacy
{
    public static void RotateInDirectionOnYAxis(this Transform rotationTransform, Vector3 rotationDirection, float rotationSpeed)
    {
        if (rotationDirection == Vector3.zero) return;
        Quaternion LookAtRotation = Quaternion.LookRotation(rotationDirection);

        Quaternion LookAtRotationOnly_Y = Quaternion.Euler(rotationTransform.rotation.eulerAngles.x,
                                                           LookAtRotation.eulerAngles.y,

                                                           rotationTransform.rotation.eulerAngles.z);

        rotationTransform.rotation = Quaternion.RotateTowards(rotationTransform.rotation,
                                                              LookAtRotationOnly_Y,
                                                              rotationSpeed * Time.fixedDeltaTime);
    }

}

