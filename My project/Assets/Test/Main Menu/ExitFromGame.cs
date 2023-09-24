using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFromGame : MonoBehaviour
{
    public void ExitGame() {
        Debug.Log("Exiting the game");
        Application.Quit();
    }
}
