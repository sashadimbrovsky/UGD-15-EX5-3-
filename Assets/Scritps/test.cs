using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        PlayerController.health -= 10; 
    }

}
