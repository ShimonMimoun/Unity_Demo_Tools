using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component lets its object shoot a laser
 *      whenever the player clicks Space.
 */
public class KeyboardShooter : MonoBehaviour {
    [Tooltip("Prefab for laser shot by the player")]
    [SerializeField] GameObject laserPrefab = null;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 laserPosition = new Vector3(transform.position.x, transform.position.y + 1, 0);
            Quaternion laserRotation = Quaternion.identity;
            Instantiate(laserPrefab, laserPosition, laserRotation);

            /* To get the newly instantiated object, you can do:
            GameObject newLaserObject = Instantiate(laserPrefab, laserPosition, laserRotation);
            Laser newLaserComponent = newLaserObject.GetComponent<Laser>();
            */
        }
    }
}
