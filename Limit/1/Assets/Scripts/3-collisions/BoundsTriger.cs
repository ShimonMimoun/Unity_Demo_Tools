using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsTriger : MonoBehaviour
{
    //All bounds are for the player, enemy and laser except of the upper one which is for the player and laser only.
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string[] triggeringTag = { "Player", "Laser", "Enemy" };

    private void OnTriggerEnter2D(Collider2D other)
    {
        foreach (string s in triggeringTag)
        {
            if (other.tag == s)
            {
                Destroy(other.gameObject);
            }
        }
    }
}
