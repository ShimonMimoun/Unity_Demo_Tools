using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("Speed of player movement, in units per second")] [SerializeField] float speed = 1f;
    [Tooltip("Prefab for laser shot by the player")] [SerializeField] GameObject laserPrefab = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        MovePlayer();
        Shoot();
    }

    private void Shoot() {
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
    
    private void MovePlayer() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime);
    }
}
