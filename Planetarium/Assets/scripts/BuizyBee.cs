using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuizyBee : MonoBehaviour
{
    Vector3 speed = Vector2.zero;
    Vector3 ComputeStepSize(Vector3 distanceToTarget)
    {
        return distanceToTarget / 100f;
    }

    void Update()
    {
        Vector3 cursorPos = Honeypot.Locate();
        Vector3 distance = cursorPos - transform.position;
        Vector3 step = ComputeStepSize(distance);
        speed = speed + step;
        transform.position += speed;
    }
}
