using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject planet;
    public float angularSpeed = 0.0f;
    public float rotateSpeed = 0.0f;
    private float orbitalRadius = 0.0f;
    private float angle = 0.0f;

    void Start()
    {
        orbitalRadius = planet.transform.position.x;
    }
    
    void FixedUpdate()
    {
        // Rotate around sun
        angle += angularSpeed * Time.deltaTime * 0.05f;
        float xPos = orbitalRadius * Mathf.Cos(angle);
        float zPos = orbitalRadius * Mathf.Sin(angle);
        planet.transform.position = new Vector3(xPos, 0, zPos);

        // Rotate around axis
        planet.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * 5);
    }
}
