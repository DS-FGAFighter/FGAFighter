using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerButton : MonoBehaviour {

    private string playerOneSelection;
    private string playerTwoSelection;
    private string scenarioSelection;

    // Use this for initialization
    void Start()
    {
        
    }

        public void PlayButton(string scene)
    {
        if(scene == "character-selection")
        {
            SceneManager.LoadScene("character-selection");
        }
        else if(scene == "scenario-selection")
        {
            SceneManager.LoadScene("scenario-selection");
        }
        else if(scene == "fight")
        {
            SceneManager.LoadScene("scenario1");
            //playerOneSelection = ControllerCharacterSelection.player1Selection;
            //playerTwoSelection = ControllerCharacterSelection.player2Selection;
            //scenarioSelection = ControllerScenarioSelection.scenarioSelection;

            //if (scenarioSelection == "scenario1" && playerOneSelection == "energy")
            //{
            //    SceneManager.LoadScene("energy-player");
            //}
            //else if (scenarioSelection == "scenario1" && playerOneSelection == "energy")
            //{
            //    SceneManager.LoadScene("player-energy");
            //}
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
