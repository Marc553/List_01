using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_1 : MonoBehaviour
{
    private Button buttonNumber; //makes the random number
    public TextMeshProUGUI numberText; //the number which is going to be showed
    private int numberMin = 0; //the minim number 
    private int numberMax = 6; //the maxim number

    void Start()
    {
        buttonNumber = GetComponent<Button>(); //get the button component of the button object
        buttonNumber.onClick.AddListener(SetNumberInText); //when the button is clicked, it starts the function
    }
    
    private void SetNumberInText() //function that is start when the button is clicked
    {
        int randomNumber= Random.Range(numberMin, numberMax); //creates a random number between 0 and 6(5)
        numberText.text = $"{randomNumber}"; //sets the text witch the random number

    }
    
}
