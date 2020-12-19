using UnityEngine;

// follow the cursor, by trying to stick to it
public class LazyBee : MonoBehaviour
{
    Vector3 ComputeStepSize(Vector3 distanceToTarget)
    {
        return distanceToTarget;
    }

    void Update()
    {
        Vector3 cursorPos = Honeypot.Locate();
        Vector3 distance = cursorPos - transform.position;
        Vector3 step = ComputeStepSize(distance);
        transform.position += step;
    }
}
