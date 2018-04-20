using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class хп : MonoBehaviour
{
    public Text Healthtxt;

    // Use this for initialization
    void Start()
    {
        Healthtxt.text = PlayerController.health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.health >= 0)
        {
         Healthtxt.text = PlayerController.health.ToString()+"HP";

        }
        if (PlayerController.health <= 0)
        {
            print("Game Over");
        }
        if (PlayerController.health <= 65)
        {
            Healthtxt.color = new Color(241,0,255);
        }
        if (PlayerController.health <= 25)
        {
            Healthtxt.color = new Color(250, 0, 0);
        }
    }
}