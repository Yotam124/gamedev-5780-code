using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Represents an object that has a given amount of lives, and is destroyed when the number of lives becomes 0.
 */
public class HealthSystem : MonoBehaviour
{
    [Tooltip("Num of hits before the object is dead")] [SerializeField] int lives = 3;
    [Tooltip("Num of seconds to wait before destroying the object")] [SerializeField] float deathDelay = 1f;

    Transform explosion;

    private void Start() {
        explosion = transform.Find("ExplosionEffect");
    }

    public void Damage() {
        --lives;
        gameObject.transform.localScale *= 0.75f; // Notify the player that a damage was done
        if (lives<1) {
            Explosion();
        }
    }

    void Explosion() {
        //Debug.Log("explosion = " + explosion);
        if (explosion) {
            //Debug.Log("explosion gameObject = " + explosion.gameObject);
            explosion.gameObject.SetActive(true);
            gameObject.GetComponent<Renderer>().enabled = false; // hide player during the xplosion
        }
        //Destroy(gameObject, deathDelay); // This will be done by an animation event.
    }
}
