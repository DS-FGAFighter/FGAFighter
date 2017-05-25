using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerEnergyPlayerOneAttack : MonoBehaviour {

    private Slider player2Slider;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player2")
        {
            GameObject temp = GameObject.FindWithTag("Player2Slider");
            if (temp != null)
            {
                player2Slider = temp.GetComponent<Slider>();
            }
            player2Slider.value -= 15;

            Destroy(gameObject);
        }
        if (coll.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
