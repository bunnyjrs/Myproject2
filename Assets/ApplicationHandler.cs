using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This component can be used to access methods for changing the scene, and quitting the game
// It can be used together with UnityEventOnTrigger, or UI-button-events, to decide when a scene should be changed or the game should be closed
public class ApplicationHandler : MonoBehaviour
{
    public void ChangeScene()
    {
        switch (transform.parent.name)
        {
            case "Start":
                SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
                break;
            case "Menu":
                SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);
                break;
            default:
                break;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
