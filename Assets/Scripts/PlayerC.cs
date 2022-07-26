using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    public float waktu = 5.0f;
    public float turnSpeed;
    public float verticalInput;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move the vehicle base on vertical input 
        transform.Translate(Vector3.forward *Time.deltaTime * waktu * verticalInput);
        //move the vehicle base on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); 

        
    }
}
