﻿using UnityEngine;

public class Planet : MonoBehaviour
{    
    Vector3 speed = Vector2.zero;
    [HideInInspector]
    public float mass = 1;
    public GameObject p;
    Vector3 velocity = Vector3.zero;
     Planet other;
    public static GameObject[] otherP;

    private static float G = 1f;   // universal gravity constant

    void Awake()
    {
        mass = transform.localScale.x;
        other = p.GetComponent<Planet>();
    }
    Vector3 ComputeStepSize(Vector3 toTarget)
    {
        Vector3 dir = toTarget.normalized;
        float dist = toTarget.magnitude;
        float f = (mass * other.mass) / (dist * dist);

        if(name == "earth")
           print( "<color=blue>pos: " + transform.position + "dist: " + dist + " speed: " + speed + " f: " + f + "</color>");


        if (dist < 1f)
            return Vector3.zero;

        if (f > 0.3f)
            f = 0.3f;

       return f * dir / 50f;
    }

  
    void Start()
    {
        if (otherP == null)
            otherP = GameObject.FindGameObjectsWithTag("Planet");
    }

    void Update()
    {
        // foreach (GameObject p in otherP)
        // {
        //if (p != gameObject)
        //  {
        Vector3 PlanetPos = p.transform.position;
                Vector3 distance = PlanetPos - transform.position;
                Vector3 a = ComputeStepSize(distance);

                speed = speed + a / mass;
                transform.position += speed;
           // }
       // }
    }

}
