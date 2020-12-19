using UnityEngine;

public class Bouncer : MonoBehaviour
{  
    Vector2 location;
    public float speedX = 3f;
	public float speedY = 3f;
	
	// later add checkbox for gravity
	// and handle wind
	
    Vector2 velocity;

    void Start()
    {
        location = transform.position;
        velocity = new Vector2(speedX, speedY);
    }

    void Update()
    {
        // adjust position over time
      
        // check for borders - do not cross right / left, top or bottom
        // if border is exceeded, invert corresponding velocity component,
        // in a mirror image..        

        // set the final position
    }

}
