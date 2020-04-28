using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator2 : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private float direction = 1;
    private float xBound = 7.6f;
    private const float _speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xBound)
        {
            direction = -1;
            speed = _speed;
        }
        if (transform.position.x < -xBound)
        {
            direction = 1;
            speed = _speed;
        }
        transform.position = new Vector3(transform.position.x + direction * speed * Time.deltaTime, transform.position.y, transform.position.z);
        speed += 10f * Time.deltaTime ;
    }
}
