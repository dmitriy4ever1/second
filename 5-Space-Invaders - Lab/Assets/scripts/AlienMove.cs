using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AlienMove : MonoBehaviour {

    public float moveInterval;
	protected enum Direction { Left, Right, Down };
   
	private bool alive = true;
    private Direction dir = Direction.Down;
    private int numSteps = 0;
    private Direction lastHoriz = Direction.Left;
    static Vector2[] actions = { Vector2.left, Vector2.left, Vector2.left, Vector2.left, Vector2.left, Vector2.down, Vector2.right, Vector2.right, Vector2.right, Vector2.right, Vector2.right, Vector2.down, };
    int i = 0;


    void Start()
    {
        if (moveInterval == 0f)
            moveInterval = 1f;

        InvokeRepeating("MoveIt", 1f, moveInterval);
    }

	
    // Update is called once per frame

    void MoveIt () {
		if (alive == false)
			return;

            transform.Translate(actions[i % actions.Length]);
  
        i++;
        print(i);


     
    }

}
