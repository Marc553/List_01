using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_8 : MonoBehaviour
{
    public string username; //varaible to save the text of the inputfild

    public GameObject panelName; //panel of the start 
    public GameObject panelAdventure; //panel of the adventure text

    public TextMeshProUGUI congratulation; //text of the adventure congratulation 

    public void ReadStringInput(string name) //function that save the text of the inputfild
    {
        username = name; //the inputfild is save in the variable
    }
    public void ConfirmButton() //function that checks if the requesites are meet
    {
         if(!string.IsNullOrWhiteSpace(username))//if the string doesn't have null or with spaces, the function will changes panels and show the message with the name that was written
        {
             panelName.SetActive(false);//turn off the panel
             panelAdventure.SetActive(true);//turn on the panel
            congratulation.text = $"Hello, {username} and welcome to this amazing adventure";//shows that mesage with the name of the user
         }
    }

    
        
}
