using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad5lab6 : MonoBehaviour{
    private Vector3 source;
    public Transform destination;
    private float moveSpeed = 2;
    private bool goBack = false;
    private bool isRunning;
    void Start(){
        source = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    void Update(){
        if (!isRunning) return;
        if (!goBack) {
            GetComponent<Transform>().position = Vector3.MoveTowards(GetComponent<Transform>().position, destination.position, moveSpeed * Time.deltaTime);
        }
        if (GetComponent<Transform>().position == destination.position) goBack = true;
        if (goBack){
            GetComponent<Transform>().position = Vector3.MoveTowards(GetComponent<Transform>().position, source, moveSpeed * Time.deltaTime);
        }
        if (GetComponent<Transform>().position == source){
            goBack = false;
            isRunning = false;
        }
    }
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")) isRunning = true;
    }
}