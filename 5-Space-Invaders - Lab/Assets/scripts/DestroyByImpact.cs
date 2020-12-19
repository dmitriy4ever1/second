using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByImpact : MonoBehaviour {

    // hit by some other object: bullet or alien: both the attacker and barrier
    // get destroyed in the collision
    void OnTriggerEnter2D(Collider2D other) {

        if (tag == "alien" && other.tag == "alienWeapon")  // aliens are not hit by friendly fire
            return;

        Destroy(other.gameObject);  
        Destroy(gameObject);
    }
	
}