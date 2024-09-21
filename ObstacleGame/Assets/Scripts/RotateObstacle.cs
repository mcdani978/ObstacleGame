using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacle : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation
    public Vector3 rotationAxis = Vector3.up; // Axis around which the object will rotate
    public Vector3 fixedPoint = Vector3.zero; // Fixed point to rotate around

    void Update()
    {
        // Rotate around the fixed point
        RotateAroundFixedPoint();

        // If you want to rotate around its own axis, uncomment the line below
        // RotateAroundOwnAxis();
    }

    void RotateAroundFixedPoint()
    {
        // Rotate the object around the fixed point
        transform.RotateAround(fixedPoint, rotationAxis, rotationSpeed * Time.deltaTime);
    }

    void RotateAroundOwnAxis()
    {
        // Rotate the object around its own axis
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
