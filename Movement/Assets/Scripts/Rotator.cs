using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float _speed = 20f;
 

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3 (0f, 1f, 0f) * Time.deltaTime * _speed);
    }
}
