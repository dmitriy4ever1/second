using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyBee : MonoBehaviour
{
    Vector3 ComputeStepSize(Vector3 distanceToTarget)
    {
        return distanceToTarget* Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cursorPos = Honeypot.Locate();
        Vector3 distance = cursorPos - transform.position;
        Vector3 step = ComputeStepSize(distance);
        transform.position += step;
    }
}
