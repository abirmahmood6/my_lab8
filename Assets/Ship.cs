// Abir Mahmood
// CSC350H
//Dr. Hao Tang
// Lab-8



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {  

    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // Destroying the ship GameObject
            Destroy(gameObject);
        }
    }
}