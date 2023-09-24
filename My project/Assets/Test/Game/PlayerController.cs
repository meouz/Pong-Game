using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    private void Start() {
        rig = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    private void Update() {
        ////return ke zero ketika tidak ada input
        ////Vector2 movement = Vector3.zero;

        MoveObject(GetInput());

        //get input
        //Vector3 movement = GetInput();
        //move object
        //MoveObject(movement);
    }

    private Vector2 GetInput() {
        if (Input.GetKey(upKey)) {
            //atas
            //movement = Vector3.right * speed;
            return Vector2.up * speed; //seharusnya Vector2.up tapi kenapa outputnya ke kiri?
        }
        else if (Input.GetKey(downKey)) {
            //bawah
            //movement = Vector3.left * speed;
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement) {
        //transform.Translate(movement * Time.deltaTime); karena sekarang sudah menggunakan velocity
        Debug.Log("Test: " +movement); //debugging x,y
        rig.velocity = movement;
    }
}