using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_10_2 : MonoBehaviour
{
    public int points;//variable with the points that will be added

    public Exercise_10_1 gameManager; //game manager script

    private void OnMouseDown()//function that do the objects clicked with the mouse 
    {
        points++;// add 1 point
        gameManager = FindObjectOfType<Exercise_10_1>();//get the script of the game manager
        gameManager.UpdateScore(points);//puts the point to the update score of the game manager
        Destroy(gameObject);//destroy the game object that has clicked
    }
}
