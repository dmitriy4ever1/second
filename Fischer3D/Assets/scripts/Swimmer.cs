using UnityEngine;

public class Swimmer : MonoBehaviour
{
    bool hooked = false;
    bool inBoat = false;
    GameObject boat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // if a fish is caught, reel it back to the boat:
    private void Update()
    {
        if (hooked == false)
            return;

        if (inBoat == true)
            return;

        if (Vector3.Distance(transform.position, boat.transform.position) > 0.25f)
        {
            transform.LookAt(boat.transform);
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        else
        {
            inBoat = true;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = boat.transform;
        }
    }
}
