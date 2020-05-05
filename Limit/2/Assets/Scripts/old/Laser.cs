using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [Tooltip("Speed in which the laser goes up, in units per second")] [SerializeField] float speed = 1f;
    [Tooltip("Maximum distance that the laser can reach, in units")] [SerializeField] float range = 5f;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (Vector3.Distance(transform.position, startPosition) > range) {
            Destroy(gameObject);
        }
    }
}
