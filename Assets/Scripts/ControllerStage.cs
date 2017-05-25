using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerStage : MonoBehaviour {

    private Text timer;
    private Text textCenter;
    private float time;
    private int updatedTime;
    private Slider player1Slider;
    private Slider player2Slider;

    //private Rigidbody2D player1;
    //private string player1Class;

    // Use this for initialization
    void Start () {

        //player1Class = "Energy";

        //if(player1Class.Equals("Energy"))
        //{
        //    GameObject tempPlayer1Energy = GameObject.FindWithTag("Player1Energy");
        //    if (tempPlayer1Energy != null)
        //    {
        //        player1 = tempPlayer1Energy.GetComponent<Rigidbody2D>();
        //    }
        //}

        //Rigidbody2D player1Instance = Instantiate(player1, new Vector3(-1.3f, -0.4f, 0f), Quaternion.Euler(new Vector3(0, 180, 0))) as Rigidbody2D;

        GameObject temp = GameObject.FindWithTag("Timer");
        if (temp != null)
        {
            timer = temp.GetComponent<Text>();
        }

        GameObject temp2 = GameObject.FindWithTag("TextCenter");
        if (temp2 != null)
        {
            textCenter = temp2.GetComponent<Text>();
        }

        GameObject temp3 = GameObject.FindWithTag("Player1Slider");
        if (temp3 != null)
        {
            player1Slider = temp3.GetComponent<Slider>();
        }

        GameObject temp4 = GameObject.FindWithTag("Player2Slider");
        if (temp4 != null)
        {
            player2Slider = temp4.GetComponent<Slider>();
        }

        time = Time.time + 121f;
        updatedTime = 120;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(updatedTime);
        if (updatedTime > 0)
        {
            updatedTime = (int)(time - Time.time);
            timer.text = updatedTime.ToString();

            if(player1Slider.value == 0)
            {
                textCenter.text = "O PLAYER 2 VENCEU!";
                Time.timeScale = 0;
            }

            if (player2Slider.value == 0)
            {
                textCenter.text = "O PLAYER 1 VENCEU!";
                Time.timeScale = 0;
            }
        }
        else if(updatedTime == 0)
        {
            textCenter.text = "O TEMPO ACABOU!";
            Time.timeScale = 0;
        }
    }
}
