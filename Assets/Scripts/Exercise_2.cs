using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_2 : MonoBehaviour
{
    public TextMeshProUGUI solution; //is going to say if the number is odd or even
    public int numberDisplay; //where the number to check is going to be placed

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //will check if space is presed to execute the function
        {
            int numberResidue; //residue of the operation

            numberResidue = numberDisplay % 2; //operate if is an odd or an even number

            if(numberResidue == 0) //checks what's the solution and order what say in the text mesh
            {
                solution.text = "Is an Even Number"; //if is even
            }
            else
            {
                solution.text = "Is an Odd Number"; //if is odd
            }
        }
    }
}
