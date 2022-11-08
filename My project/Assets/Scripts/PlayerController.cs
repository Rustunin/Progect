using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * playerSpeed);
    }
}
