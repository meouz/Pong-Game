using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D bola;
    public bool isRight;
    public ScoreManager manager;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision == bola) {
            if (isRight) {
                manager.AddrightScore(1);
            }
            else {
                manager.AddleftScore(1);
            }
        }
    }
}
