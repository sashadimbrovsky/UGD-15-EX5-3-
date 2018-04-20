using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pastka1 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
     PlayerController.health -= 10;
            print("біжи");
        }
    void Update()
    {
        print(PlayerController.health);
    }
}
