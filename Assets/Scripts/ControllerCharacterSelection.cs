using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerCharacterSelection : MonoBehaviour {

    private Text textCenter;
    private Text playerOneText;
    private Text playerTwoText;
    private Toggle aerospaceToggle;
    private Toggle eletronicToggle;
    private Toggle energyToggle;
    private Toggle softwareToggle;
    private Toggle automotiveToggle;
    //NINJA
    private Toggle ninjaToggle;
    //NINJA
    private Button chooseScenarioButton;
    public static string player1Selection;
    public static string player2Selection;
    private float time;

    private bool playerOneSelectMoment()
    {
        if (player1Selection == null)
            return true;
        else
            return false;
    }

    private bool playerTwoSelectMoment()
    {
        if (player1Selection != null && player2Selection == null)
            return true;
        else
            return false;
    }

    private void lockUnlock()
    {
        aerospaceToggle.interactable = true;
        eletronicToggle.interactable = true;
        energyToggle.interactable = true;
        softwareToggle.interactable = true;
        automotiveToggle.interactable = true;
        //NINJA
        ninjaToggle.interactable = true;
        //NINJA

        if (player1Selection == "aerospace")
        {
            aerospaceToggle.interactable = false;
        }
        else if (player1Selection == "eletronic")
        {
            eletronicToggle.interactable = false;
        }
        else if (player1Selection == "energy")
        {
            energyToggle.interactable = false;
        }
        else if (player1Selection == "software")
        {
            softwareToggle.interactable = false;
        }
        else if (player1Selection == "automotive")
        {
            automotiveToggle.interactable = false;
        }
        //NINJA
        else if (player1Selection == "ninja")
        {
            ninjaToggle.interactable = false;
        }
        //NINJA
    }

    private void setPlayerOneText()
    {
        if (player1Selection == "aerospace")
        {
            playerOneText.text = "PLAYER 1\nAEROESPACIAL";
        }
        else if (player1Selection == "eletronic")
        {
            playerOneText.text = "PLAYER 1\nELETRÔNICA";
        }
        else if (player1Selection == "energy")
        {
            playerOneText.text = "PLAYER 1\nENERGIA";
        }
        else if (player1Selection == "software")
        {
            playerOneText.text = "PLAYER 1\nSOFTWARE";
        }
        else if (player1Selection == "automotive")
        {
            playerOneText.text = "PLAYER 1\nAUTOMOTIVA";
        }
        //NINJA
        else if (player1Selection == "ninja")
        {
            playerOneText.text = "PLAYER 1\nNINJA";
        }
        //NINJA
    }

    private void setPlayerTwoText()
    {
        if (player2Selection == "aerospace")
        {
            playerTwoText.text = "PLAYER 2\nAEROESPACIAL";
        }
        else if (player2Selection == "eletronic")
        {
            playerTwoText.text = "PLAYER 2\nELETRÔNICA";
        }
        else if (player2Selection == "energy")
        {
            playerTwoText.text = "PLAYER 2\nENERGIA";
        }
        else if (player2Selection == "software")
        {
            playerTwoText.text = "PLAYER 2\nSOFTWARE";
        }
        else if (player2Selection == "automotive")
        {
            playerTwoText.text = "PLAYER 2\nAUTOMOTIVA";
        }
        //NINJA
        else if (player2Selection == "ninja")
        {
            playerTwoText.text = "PLAYER 2\nNINJA";
        }
        //NINJA
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("scenario-selection");
    }

    // Use this for initialization
    void Start () {

        GameObject temp = GameObject.FindWithTag("TextCenter");
        if (temp != null)
        {
            textCenter = temp.GetComponent<Text>();
        }

        GameObject temp2 = GameObject.FindWithTag("AerospaceToggle");
        if (temp2 != null)
        {
            aerospaceToggle = temp2.GetComponent<Toggle>();
        }

        GameObject temp3 = GameObject.FindWithTag("EletronicToggle");
        if (temp3 != null)
        {
            eletronicToggle = temp3.GetComponent<Toggle>();
        }

        GameObject temp4 = GameObject.FindWithTag("EnergyToggle");
        if (temp4 != null)
        {
            energyToggle = temp4.GetComponent<Toggle>();
        }

        GameObject temp5 = GameObject.FindWithTag("SoftwareToggle");
        if (temp5 != null)
        {
            softwareToggle = temp5.GetComponent<Toggle>();
        }

        GameObject temp6 = GameObject.FindWithTag("AutomotiveToggle");
        if (temp6 != null)
        {
            automotiveToggle = temp6.GetComponent<Toggle>();
        }

        GameObject temp7 = GameObject.FindWithTag("PlayerOneText");
        if (temp7 != null)
        {
            playerOneText = temp7.GetComponent<Text>();
        }

        GameObject temp8 = GameObject.FindWithTag("PlayerTwoText");
        if (temp8 != null)
        {
            playerTwoText = temp8.GetComponent<Text>();
        }

        GameObject temp9 = GameObject.FindWithTag("ChooseScenarioButton");
        if (temp9 != null)
        {
            chooseScenarioButton = temp9.GetComponent<Button>();
        }

        //NINJA
        GameObject temp10 = GameObject.FindWithTag("NinjaToggle");
        if (temp10 != null)
        {
            ninjaToggle = temp10.GetComponent<Toggle>();
        }
        //NINJA

        textCenter.text = "SELEÇÃO DE PERSONAGENS (PLAYER 1)";

        player1Selection = null;
        player2Selection = null;
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log("1: " + player1Selection + " 2: " + player2Selection);

        if (playerOneSelectMoment())
        {
            if (aerospaceToggle.isOn)
            {
                aerospaceToggle.interactable = false;
                player1Selection = "aerospace";
            }
            else if (eletronicToggle.isOn)
            {
                eletronicToggle.interactable = false;
                player1Selection = "eletronic";
            }
            else if (energyToggle.isOn)
            {
                energyToggle.interactable = false;
                player1Selection = "energy";
            }
            else if (softwareToggle.isOn)
            {
                softwareToggle.interactable = false;
                player1Selection = "software";
            }
            else if (automotiveToggle.isOn)
            {
                automotiveToggle.interactable = false;
                player1Selection = "automotive";
            }
            //NINJA
            else if (ninjaToggle.isOn)
            {
                ninjaToggle.interactable = false;
                player1Selection = "ninja";
            }
            //NINJA
            if (player1Selection != null)
            {
                textCenter.text = "SELEÇÃO DE PERSONAGENS (PLAYER 2)";
                aerospaceToggle.interactable = false;
                eletronicToggle.interactable = false;
                energyToggle.interactable = false;
                softwareToggle.interactable = false;
                automotiveToggle.interactable = false;
                time = Time.time + 0.5f; // Timer before select player 2 character
                setPlayerOneText();
                //NINJA
                ninjaToggle.interactable = false;
                //NINJA
            }
        }
        else if (time < Time.time && playerTwoSelectMoment())
        {
            lockUnlock();

            if (aerospaceToggle.isOn && player1Selection != "aerospace")
            {
                player2Selection = "aerospace";
            }
            else if (eletronicToggle.isOn && player1Selection != "eletronic")
            {
                player2Selection = "eletronic";
            }
            else if (energyToggle.isOn && player1Selection != "energy")
            {
                player2Selection = "energy";
            }
            else if (softwareToggle.isOn && player1Selection != "software")
            {
                player2Selection = "software";
            }
            else if (automotiveToggle.isOn && player1Selection != "automotive")
            {
                player2Selection = "automotive";
            }
            //NINJA
            else if (ninjaToggle.isOn && player1Selection != "ninja")
            {
                player2Selection = "ninja";
            }
            //NINJA
            if (player1Selection != null && player2Selection != null)
            {
                aerospaceToggle.interactable = false;
                eletronicToggle.interactable = false;
                energyToggle.interactable = false;
                softwareToggle.interactable = false;
                automotiveToggle.interactable = false;
                textCenter.text = "PRONTO PARA JOGAR!";
                setPlayerTwoText();
                chooseScenarioButton.interactable = true;
                //NINJA
                ninjaToggle.interactable = false;
                //NINJA
            }
        }
        //NINJA
        aerospaceToggle.interactable = false;
        eletronicToggle.interactable = false;
        softwareToggle.interactable = false;
        automotiveToggle.interactable = false;
        //NINJA

        //----------- TO USE WITH ONLY ENERGY --------------------------------------

        //aerospaceToggle.interactable = false;
        //eletronicToggle.interactable = false;
        //softwareToggle.interactable = false;
        //automotiveToggle.interactable = false;

        // to play with player 1
        //player2Selection = "generic";
        //playerTwoText.text = "PLAYER 2\nGENÉRICO";
        //if (player1Selection != null)
        //{
        //    textCenter.text = "PRONTO PARA JOGAR!";
        //    chooseScenarioButton.interactable = true;
        //}

        // to play with player 2
        //player1Selection = "generic";
        //playerOneText.text = "PLAYER 1\nGENÉRICO";
        //textCenter.text = "SELEÇÃO DE PERSONAGENS (PLAYER 2)";
        //if (player2Selection != null)
        //{
        //    textCenter.text = "PRONTO PARA JOGAR!";
        //    chooseScenarioButton.interactable = true;
        //}

        // ------------------------------------------------------------------------
    }
}
