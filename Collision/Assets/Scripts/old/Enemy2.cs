using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {
    [Tooltip("Direction and speed of movement, in units/sec")]
    [SerializeField] Vector3 speedVector;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.Translate(speedVector * Time.deltaTime);
        // TODO: destroy when out of screen
    }

    // Detect the collider type by its component:
    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<Laser>()) {
            Debug.Log("Enemy is hit by laser!");
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        } else if (other.GetComponent<PlayerController>() && other.GetComponent<HealthSystem>()) {
            Debug.Log("Enemy hits the player!");
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<HealthSystem>().Damage();
            Destroy(this.gameObject);
        } else if (other.GetComponent<Wall>()) {
            Debug.Log("Enemy crashes into wall!");
            Destroy(this.gameObject);
        }
    }

    /*
    // Detect the collider type by its tag:
    private void OnTriggerEnter(Collider other) {
        if (other.tag=="Laser") {
            Debug.Log("Enemy is hit by laser!");
            Destroy(this.gameObject);
        } else if (other.tag=="Player") {
            Debug.Log("Enemy hits the player!");
            Destroy(other.gameObject);
        } else if (other.tag=="Wall") {
            Debug.Log("Enemy crashes into wall!");
            Destroy(this.gameObject);
        }
    }
    */


}
