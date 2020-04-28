using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    [Tooltip("Rotatation Speed")] [SerializeField] private float RotateSpeed = 5f;
    [Tooltip("Raduis")] [SerializeField] private float Radius = 2f;

    private Vector2 _centre;
    private float _angle;
    private float direction = 1;
    private bool ans = false;

    private void Start()
    {
        _centre = new Vector2(transform.position.x, transform.position.y - Radius);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = 1;
            ans = true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = -1;
            ans = true;
        }
        if (ans)
        {
            _angle += RotateSpeed * Time.deltaTime * direction;

            var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
            transform.position = _centre + offset;
            ans = false;
        }
    }
}
