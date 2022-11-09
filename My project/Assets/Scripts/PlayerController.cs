using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public float rotateSpeed;
    private float verticalInput;
    private float horizontalInput;

    void Start()
    {
        
    }

    
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * verticalInput);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * horizontalInput);
    }
}
