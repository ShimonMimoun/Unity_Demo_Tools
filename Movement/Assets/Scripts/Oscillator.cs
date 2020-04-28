using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // Start is called before the first frame update
    Quaternion _start, _end;

    [Tooltip("Angle of Oscillator")] [SerializeField, Range(0.0f, 360f)] private float _angle = 90.0f;

    [Tooltip("speed m//s")] [SerializeField, Range(0.0f, 5.0f)]private float _speed = 2.0f;

    [Tooltip("Start Time (S)")] [SerializeField, Range(0.0f, 10.0f)] private float _startTime = 0.0f;
    void Start()
    {
        _start = PendulimRotation(_angle);
        _end = PendulimRotation(-_angle);
    }

    private Quaternion PendulimRotation(float angle)
    {
        var pendulumRotation = transform.rotation;
        var angleZ = pendulumRotation.eulerAngles.z + angle;

        if (angleZ > 180) angleZ -= 360;
        else if (angleZ < -180) angleZ += 360;

        pendulumRotation.eulerAngles = new Vector3(pendulumRotation.eulerAngles.x, pendulumRotation.eulerAngles.y, angleZ);
        return pendulumRotation;
    }

    // Update is called once per frame
    void Update()
    {
        _startTime += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(_start, _end, (Mathf.Sin(_startTime * _speed + Mathf.PI / 2) + 1.0f) / 2.0f);
    }
}
