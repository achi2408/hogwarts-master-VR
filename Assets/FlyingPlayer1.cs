using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FlyingPlayer1 : MonoBehaviour
{
    private GameObject go;

    static int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("moveHarryPotter", 2.0f, 0.05f);
       
    }



    void moveHarryPotter()
    {


        // Move the object forward along its z axis 1 unit/second

        //count++;
        //if(count % 5 == 0 && count %10 !=0)
        //{
        //  transform.Translate(Vector3.up * 5);
        //}
        //if(count %10 ==0)ß
        //{
        //  transform.Translate(Vector3.down * 5);
        //}
        if (count == 50)
        {
            count = 0;
            transform.Rotate(0f, 0f, 180f, Space.Self);
        }
        transform.Translate(Vector3.right * 5f);
       
        count++;


        //transform.Translate(Vector3.right * 5);

        
        // Move the object upward in world space 1 unit/second.

    }

    // Update is called once per frame
    void Update()
    {
        Console.WriteLine("This is C#");
    }
}
