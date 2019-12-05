using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HarryPotterFlyingJat : MonoBehaviour
{
    private GameObject go;

   
   
    // Start is called before the first frame update
    void Start()
    {    
        InvokeRepeating("moveHarryPotter", 2.0f, 0.3f);
    }

    void moveHarryPotter()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * 5);

        // Move the object upward in world space 1 unit/second.
        transform.Translate(Vector3.up * 5, Space.World);
    }
  
    // Update is called once per frame
    void Update()
    {
        Console.WriteLine("This is C#");
    }
}
