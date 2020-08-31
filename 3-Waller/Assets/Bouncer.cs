using UnityEngine;

public class Bouncer : MonoBehaviour
{  
    Vector2 location;
    public float speed = 3f;
    Vector2 velocity;

    void Start()
    {
        location = transform.position;
        velocity = new Vector2(speed, speed);
    }

    void Update()
    {
        if (location.y >= 5f && velocity.y > 0)
        {
            velocity = new Vector2(velocity.x, -velocity.y);
        }


        if (location.y <= -5f && velocity.y < 0)
        {
            velocity = new Vector2(velocity.x, -velocity.y);
        }


        if (location.x >= 8f && velocity.x > 0)
        {
            velocity = new Vector2(-velocity.x, velocity.y);
        }


        if (location.x <= -8f && velocity.x < 0)
        {
            velocity = new Vector2(-velocity.x, velocity.y);
        }

        location = location + velocity * Time.deltaTime;
        transform.position = location;
    }

}
