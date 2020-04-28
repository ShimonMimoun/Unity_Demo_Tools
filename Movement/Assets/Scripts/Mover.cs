using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Speed m/s")] [SerializeField]  private float speed = 10;
    private float xBound = 7.5f;
    private float yBound = 4.3f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            if (transform.position.y > -yBound) transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            if (transform.position.y < yBound) transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            if (transform.position.x > -xBound) transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            if (transform.position.x < xBound) transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
