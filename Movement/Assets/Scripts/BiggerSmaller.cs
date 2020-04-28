using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiggerSmaller : MonoBehaviour
{
    [Tooltip("Limitation")] [SerializeField] private float xlimit = 5;
    [Tooltip("Direction")] [SerializeField] private float direction = 0.05f; 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     if(transform.localScale.x > xlimit || transform.localScale.x < 1){direction *= -1;}
     transform.localScale = new Vector3(transform.localScale.x + direction, transform.localScale.y + direction, transform.localScale.z + direction);
    }
}
