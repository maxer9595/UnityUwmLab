using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad4 : MonoBehaviour

public class Zadanie4 : MonoBehaviour
{
    public float speed = 10;
    public float distanceTravelled = 0;
    public Vector3 direction = Vector3.right;

    void Start()
    {

    }

    void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        distanceTravelled += speed / 100;
        if (distanceTravelled >= 10)
        {
            distanceTravelled = 0;
            transform.Rotate(0, 90f, 0);
        }
    }
}