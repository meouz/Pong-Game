using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleLevelUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D bola;
    public Collider2D player1;
    public Collider2D player2;
    public float scale;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == bola) {
            player1.GetComponent<PlayerController>().ActivePaddleLevelUp(scale);
            player2.GetComponent<PlayerController>().ActivePaddleLevelUp(scale);
            manager.RemovePowerUp(gameObject);
        }
    }
}
