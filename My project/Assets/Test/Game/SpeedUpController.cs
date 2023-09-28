using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D bola;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == bola) {
            bola.GetComponent<BolaController>().ActiveSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
