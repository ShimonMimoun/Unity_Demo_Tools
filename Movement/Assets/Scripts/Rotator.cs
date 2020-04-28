using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update

    [Tooltip("Rotator")] [SerializeField] private float _speed = 2.0f;
 

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3 (0, 0, 1f) * Time.deltaTime * _speed);
    }
}
