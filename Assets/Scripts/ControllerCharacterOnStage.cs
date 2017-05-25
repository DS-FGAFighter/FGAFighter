using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCharacterOnStage : MonoBehaviour {

    private string playerOneSelection;
    private string playerTwoSelection;
    //private Sprite ninjaPlayerOne;
    //private Sprite ninjaPlayerTwo;
    //private Sprite energyPlayerOne;
    //private Sprite energyPlayerTwo;

    private GameObject ninjaPlayerOneObject;
    private GameObject ninjaPlayerTwoObject;
    private GameObject energyPlayerOneObject;
    private GameObject energyPlayerTwoObject;

    // Use this for initialization
    void Start () {
        //personagens

        playerOneSelection = ControllerCharacterSelection.player1Selection;
        playerTwoSelection = ControllerCharacterSelection.player2Selection;

        ninjaPlayerOneObject = GameObject.FindWithTag("Player1");
        //if (ninjaPlayerOneObject != null)
        //{
        //    ninjaPlayerOne = ninjaPlayerOneObject.GetComponent<Sprite>();
        //}
        ninjaPlayerTwoObject = GameObject.FindWithTag("Player2");
        //if (ninjaPlayerTwoObject != null)
        //{
        //    ninjaPlayerTwo = ninjaPlayerTwoObject.GetComponent<Sprite>();
        //}
        energyPlayerOneObject = GameObject.FindWithTag("Player1Energy");
        //if (energyPlayerOneObject != null)
        //{
        //    energyPlayerOne = energyPlayerOneObject.GetComponent<Sprite>();
        //}
        energyPlayerTwoObject = GameObject.FindWithTag("Player2Energy");
        //if (energyPlayerTwoObject != null)
        //{
        //    energyPlayerTwo = energyPlayerTwoObject.GetComponent<Sprite>();
        //}

        // PLAYER 1
        if (playerOneSelection == "energy")
        {
            energyPlayerOneObject.transform.position = new Vector3(-1.3f, -0.5f, 0f);
            Destroy(ninjaPlayerOneObject);
        }
        else if(playerOneSelection == "aerospace")
        {
            // Nothing to do
        }
        else if (playerOneSelection == "eletronic")
        {
            // Nothing to do
        }
        else if (playerOneSelection == "software")
        {
            // Nothing to do
        }
        else if (playerOneSelection == "automotive")
        {
            // Nothing to do
        }
        //NINJA
        else if (playerOneSelection == "ninja")
        {
            ninjaPlayerOneObject.transform.position = new Vector3(-1.3f, -0.5f, 0f);
            Destroy(energyPlayerOneObject);
        }
        //NINJA

        // PLAYER 2
        if (playerTwoSelection == "energy")
        {
            energyPlayerTwoObject.transform.position = new Vector3(1.3f, -0.5f, 0f);
            Destroy(ninjaPlayerTwoObject);
        }
        else if (playerTwoSelection == "aerospace")
        {
            // Nothing to do
        }
        else if (playerTwoSelection == "eletronic")
        {
            // Nothing to do
        }
        else if (playerTwoSelection == "software")
        {
            // Nothing to do
        }
        else if (playerTwoSelection == "automotive")
        {
            // Nothing to do
        }
        //NINJA
        else if (playerTwoSelection == "ninja")
        {
            ninjaPlayerTwoObject.transform.position = new Vector3(1.3f, -0.5f, 0f);
            Destroy(energyPlayerTwoObject);
        }
        //NINJA
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
