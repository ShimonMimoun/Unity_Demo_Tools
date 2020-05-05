using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 20;
    private float leftBound = -15;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            GameObject.Find("Rock").transform.Rotate(0, 0, -1);
        }
        else
        {
            GameObject.Find("Rock").transform.Rotate(0, 0, -1);
            //GameObject.Find("Rock").transform.Rotate(Vector3.left * Time.deltaTime * 100f);
            GameObject.Find("Rock").transform.Translate(0, 0, -1);
        }
            
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}
