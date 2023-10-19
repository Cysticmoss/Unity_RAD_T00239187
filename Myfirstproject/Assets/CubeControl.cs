using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //xyz
        if (Input.GetKey(KeyCode.W))    
        transform.position += transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position += (new Vector3(0, -1, 0)) * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position += (new Vector3(-1, 0, 0)) * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += (new Vector3(1, 0, 0)) * Time.deltaTime;

        if(Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up,180 * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up, angle: -180 * Time.deltaTime);


    }
}

