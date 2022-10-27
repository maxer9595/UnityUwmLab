using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour

{
    public float speed = 5;
    public float distanceTravelled = 0;
    public bool is_forward = true;
    public Vector3 direction = Vector3.right;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        distanceTravelled += speed/50;
        if (distanceTravelled >= 10)
        {
            distanceTravelled = 0;
            //start
            if (is_forward)
            {
                direction = Vector3.left;
                is_forward = false;
            }
            //return
            else
            {
                direction = Vector3.right;
                is_forward = true;
            }
        }
    }
}