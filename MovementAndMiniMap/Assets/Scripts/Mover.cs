using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private float xBound = 4.5f;
    private float yBound = 4.5f;
    private KeyCode last;
    private bool first = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -yBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < yBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -xBound)
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < xBound){
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
