using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Represents an object that has a given amount of lives, and is destroyed when the number of lives becomes 0.
 */
public class HealthSystem : MonoBehaviour
{
    [SerializeField] int lives = 3;

    public void Damage() {
        --lives;
        gameObject.transform.localScale *= 0.75f; // Notify the player that a damage was done
        if (lives<1) {
            Destroy(this.gameObject);
        }
    }
}
