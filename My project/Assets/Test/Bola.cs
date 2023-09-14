using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        transform.position = transform.position + (new Vector3(1f, 1f, 0) * Time.deltaTime);
    }
}
