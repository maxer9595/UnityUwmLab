using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad4lab6 : MonoBehaviour{

    private bool isRunning;

    void Update(){
        if (!isRunning) return;
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 playerVelocity = new Vector3(0,0,0);
            playerVelocity.y += 60;
            other.gameObject.GetComponent<CharacterController>().Move(playerVelocity * Time.deltaTime);
        }
    }
}