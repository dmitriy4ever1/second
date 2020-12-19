using UnityEngine;

public class Decision : MonoBehaviour
{
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>(); 
    }

    // upon collision with bubble, make a choice to go left or right
    // and make a corresponding move
}
