using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerEnergyPlayerTwoAttack : MonoBehaviour {

    private Slider player1Slider;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player1")
        {
            GameObject temp = GameObject.FindWithTag("Player1Slider");
            if (temp != null)
            {
                player1Slider = temp.GetComponent<Slider>();
            }
            player1Slider.value -= 15;

            Destroy(gameObject);
        }
        if (coll.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
