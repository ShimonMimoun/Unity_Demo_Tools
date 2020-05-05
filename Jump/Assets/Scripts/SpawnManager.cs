using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawn;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    [SerializeField] private float startDelay = 2;
    [SerializeField] private float repeatDelay = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }

    void SpawnObstacle()
    {
        if(!playerControllerScript.gameOver)
            Instantiate(spawn, spawnPos, spawn.transform.rotation);
    }
}
