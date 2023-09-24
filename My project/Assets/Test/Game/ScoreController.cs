using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text RightScore;
    public Text LeftScore;

    public ScoreManager manager;

    private void Update() {
        RightScore.text = manager.rightScore.ToString();
        LeftScore.text = manager.leftScore.ToString();
    }

}