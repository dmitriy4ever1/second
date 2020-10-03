using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBoat : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
            transform.Translate(-0.05f, 0, 0);
        if (Input.GetMouseButton(1))
            transform.Translate(0.05f , 0, 0);

    }
}
