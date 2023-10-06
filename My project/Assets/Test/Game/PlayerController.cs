using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    private float timerPaddleSpeedUp;
    private float timerPaddleLevelUp;

    public float magnitudePaddleSpeedUp;
    private bool PaddleLevelUp;
    private bool PaddleSpeedUp;

    private void Start() {
        rig = GetComponent<Rigidbody2D>();    
        timerPaddleLevelUp = 0;
        timerPaddleSpeedUp = 0;
        PaddleLevelUp = false;
        PaddleSpeedUp = false;
    }

    private void Update() {
        MoveObject(GetInput());

        if (PaddleSpeedUp == true) {
            timerPaddleSpeedUp += Time.deltaTime;

            if (timerPaddleSpeedUp > 5) {
                DeActivePaddleSpeedUp(magnitudePaddleSpeedUp);
                timerPaddleSpeedUp = 0;
            }
        }

        if (PaddleLevelUp == true) {
            timerPaddleLevelUp += Time.deltaTime;

            if (timerPaddleLevelUp > 5) {
                DeActivePaddleLevelUp();
                timerPaddleLevelUp = 0;
            }
        }

    }

    private Vector2 GetInput() {
        if (Input.GetKey(upKey)) {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey)) {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement) {
        Debug.Log("Test: " +movement); //debugging x,y
        rig.velocity = movement;
    }

    public void ActivePaddleSpeedUp(float magnitude) {
        speed *= (int) (magnitude);
        PaddleSpeedUp = true;
    }

    public void DeActivePaddleSpeedUp(float magnitude) {
        speed /= (int) (magnitude);
        PaddleSpeedUp = false;
    }

    public void ActivePaddleLevelUp(float scale) {
        transform.localScale = new Vector3(scale, 0.2f, 1f);
        PaddleLevelUp = true;
    }

    public void DeActivePaddleLevelUp() {
        transform.localScale = new Vector3(1f, 0.2f, 1f);
        PaddleLevelUp = false;
    }
}