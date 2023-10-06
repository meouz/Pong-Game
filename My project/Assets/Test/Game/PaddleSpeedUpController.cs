using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D bola;
    public Collider2D player1;
    public Collider2D player2;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == bola) {
            player1.GetComponent<PlayerController>().ActivePaddleSpeedUp(magnitude);
            player2.GetComponent<PlayerController>().ActivePaddleSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
