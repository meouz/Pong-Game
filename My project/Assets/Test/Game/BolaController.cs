using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;

    private Rigidbody2D rig;
    
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
        // GetComponent<Transform>(); 
    }

    // Update is called once per frame
    // private void Update()
    // {
    //     //Vector3 pos = transform.position; // 3 arah sumbu vektor
    //     //transform.position = transform.position + (new Vector3(0.1f, 0, 0) * Time.deltaTime); // vektor x, y, z
    //     //transform.Translate(new Vector3 (1f,1f,0)*Time.deltaTime); // Time.deltaTime nilainya bertambah sesuai detik real time
    //     transform.Translate(speed * Time.deltaTime); // bisa move-able dengan mudah
    // }

    public void ResetBola() {
        transform.position = new Vector3((resetPosition.x), (resetPosition.y), 2);
        rig.velocity = speed*(-1);
    }

    public void ActiveSpeedUp(float magnitude) {
        rig.velocity *= magnitude;
    }
}
