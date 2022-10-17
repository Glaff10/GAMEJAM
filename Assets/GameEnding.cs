using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public void ExitGame() {
        Application.Quit();
        Debug.Log("sai show");
    }
}
