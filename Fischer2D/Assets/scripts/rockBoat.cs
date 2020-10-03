using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockBoat : MonoBehaviour
{
    public float waveLeanth = 1;
    public float rockforce = 1;
    void Start()
    {
        InvokeRepeating("Switch", waveLeanth/2, waveLeanth/2);
      //  rockforce = rockforce / 100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rockforce*3);
    }
    void Switch()
    {
        rockforce = rockforce * -1;
    }


}
