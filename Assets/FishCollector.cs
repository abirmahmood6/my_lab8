// Abir Mahmood
// CSC350H
//Dr. Hao Tang
// Lab-8

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FishCollector : MonoBehaviour
{

    [SerializeReference] GameObject fishPrefab;
    List<GameObject> fishList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // calculating the world position of moues click

            Vector3 position_Mouse = Input.position_Mouse;
            position_Mouse.z = -Camera.main.transform.position.z;
            Vector3 position_world = Camera.main.ScreenToWorldPoint(position_Mouse);

            GameObject fish = Instantiate<GameObject>(fishPrefab);
            fish.transform.position = position_world;

            fishList.Add(fish);

        }
    }
}