using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [Tooltip("Direction and speed of movement, in units/sec")]
    [SerializeField]  Vector3 speedVector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedVector * Time.deltaTime);
        // TODO: destroy when out of screen
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Enemy is hit!");
        Destroy(this.gameObject);
    }
}
