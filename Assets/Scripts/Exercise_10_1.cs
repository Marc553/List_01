using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise_10_1 : MonoBehaviour
{
    private int score = 0;// variable that will save the score
    public TextMeshProUGUI pointsText;//twxt where the score will be showed

    public void UpdateScore(int pointsToAdd)//function that will change the noumber of the score and changed in the text 
    {
        score += pointsToAdd; //will change the score with the points of the function update
        pointsText.text = $"Score: {score}";//show the socre with the socre points
    }
}
