﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float speed = 0.01f; 
    void Start()
    {

    }
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speed);
    }
}