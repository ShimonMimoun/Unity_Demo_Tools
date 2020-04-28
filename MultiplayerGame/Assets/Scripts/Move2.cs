using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    [Tooltip("Speed m/s")] [SerializeField] float speed;
    void Start()
    {
        speed = 10;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
      
    }
}
