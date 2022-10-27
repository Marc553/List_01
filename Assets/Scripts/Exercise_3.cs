using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    public GameObject cubePosition; //determinate the cube position
    private float z = 25.5f; // z position

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) //when enter is pressed changes the cube position
        {
            cubePosition.transform.position = RandomSpawnPosition(); //changes the cube position
        }
    }

    private Vector3 RandomSpawnPosition() //function that calculates a random vector
    {
        int xPosition = Random.Range(-8, 9);//calculates a random number between -8 and 8 for x
        int yPosition = Random.Range(-4, 5);//calculates a random number between -4 and 4 for y

        return new Vector3(xPosition, yPosition, z); //return a random vector 
    }
}
