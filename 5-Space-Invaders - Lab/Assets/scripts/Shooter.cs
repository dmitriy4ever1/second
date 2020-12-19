using UnityEngine;

public class Shooter : MonoBehaviour {

    public bool playerControlled;

    public GameObject weapon;

    void RandomFire()
    {
        int myTurn = Random.Range(1, 500);
        if (myTurn < 5)
            Fire(Vector2.down);
    }

    void Fire(Vector2 direction)
    {
        // print("firing cannon");
        GameObject bullet = Instantiate(weapon, transform.position, Quaternion.identity);

        bullet.transform.parent = null;     // detach from platform 
        bullet.GetComponent<Rigidbody2D>().AddForce(direction);     // up or down
        Destroy(bullet, 3f);        // nothing lasts forever
    }

	// Update is called once per frame
	void Update () {
        if (playerControlled)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Fire(Vector2.up);
        }
        else
            RandomFire();
	}
}
