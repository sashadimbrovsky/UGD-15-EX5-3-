using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscript : MonoBehaviour
{
    public int keyid;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag ("Player")) {
            if (keyid == 0)
            {
                PlayerController.GreenKey = true;
                gameObject.SetActive(false);
                print("green key picked");
            }
            else if (keyid == 1)
            {
                PlayerController.BlueKey = true;
                gameObject.SetActive(false);
                print("blue key picked");
            }
            else
                PlayerController.RedKey = true;
                gameObject.SetActive(false);
                print("red key picked");


        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
