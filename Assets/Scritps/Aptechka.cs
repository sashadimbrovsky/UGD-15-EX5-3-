using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aptechka : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (PlayerController.health <= 80)
        {
            PlayerController.health += 20;
            gameObject.SetActive(false);
        }
    }
    void Update()
    {
        print(PlayerController.health);
    }
}