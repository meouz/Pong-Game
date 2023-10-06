using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenutoController : MonoBehaviour
{
    public void OpenCredit() {
        SceneManager.LoadScene("Credit");
    }
}
