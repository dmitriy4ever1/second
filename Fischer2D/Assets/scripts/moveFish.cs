using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFish : MonoBehaviour
{
    public GameObject boat;
    public GameObject trident;
    bool cought = false;
    bool run = false;
    public float speed;
    int rd = 1;
    float up = 0.005f;
    void Start()
    {
        InvokeRepeating("getRndUD",2, 2);
        InvokeRepeating("getLr",3, 3);
        speed = speed / 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (cought)
        {
            transform.position = boat.transform.position;
        }
        else if (run)
        {
            if (trident.transform.position.x > transform.position.x)
            {
                transform.Translate(-0.3f, up, 0);
            }
            if (trident.transform.position.x < transform.position.x)
            {
                transform.Translate(0.3f, up, 0);
            }
            Invoke("stop", 1);
        }
        else
        {
          
            transform.Translate(speed, up, 0);
        }
        /*if (transform.position.y < -4.57)
        {
            up = up * -1;
            run = false;
        }
        if (transform.position.y > 0.45)
        {
            up = up * -1;
            run = false;
        }
        if (transform.position.x < -10)
        {
            speed = speed * -1;
            run = false;
        }
        if (transform.position.x > 10)
        {
            speed = speed * -1;
            run = false;
        }*/

    }
    void getRndUD()
    {
        if (rd == 1)
            up = up * -1;
        rd = Random.Range(1, 3);
    }
    void getLr()
    {
        rd = Random.Range(1, 3);
        if (rd == 1)
            speed = speed * -1;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Trident")
        {
            int rnd = Random.Range(1, 5);
            if (rnd == 4)
            {
                Invoke("catched",0.5f);
            }
            else
            run = true;
        }

        if (col.tag == "Border")
        {
            speed = speed * -1;
            up = up * -1;
            run = false;
        }

    }
    void stop()
    {
        run = false;
    }
    void catched()
    {
        cought = true;
    }


}
