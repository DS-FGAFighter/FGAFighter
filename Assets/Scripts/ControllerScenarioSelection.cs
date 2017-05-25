using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerScenarioSelection : MonoBehaviour {

    private Text textCenter;
    private Toggle scenario1;
    private Button startGameButton;
    public static string scenarioSelection;

    // Use this for initialization
    void Start () {

        GameObject temp = GameObject.FindWithTag("TextCenter");
        if (temp != null)
        {
            textCenter = temp.GetComponent<Text>();
        }

        GameObject temp2 = GameObject.FindWithTag("Scenario1");
        if (temp2 != null)
        {
            scenario1 = temp2.GetComponent<Toggle>();
        }

        GameObject temp3 = GameObject.FindWithTag("StartGameButton");
        if (temp3 != null)
        {
            startGameButton = temp3.GetComponent<Button>();
        }

        textCenter.text = "SELEÇÃO DE CENÁRIO";

        scenarioSelection = null;
    }

    // Update is called once per frame
    void Update () {
     
        if (scenario1.isOn)
        {
            scenario1.interactable = false;
            startGameButton.interactable = true;
            scenarioSelection = "scenario1";
        }
    }
}
