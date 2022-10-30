using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_6 : MonoBehaviour
{
    public Material[] colorCylinder; //array of the colors
    public GameObject cylinder; //cylinder

    public void DropdownSlection(int selection) //the dropdown that display the colors 
    {
        cylinder.GetComponent<Renderer>().material = colorCylinder[selection]; //change the cylinder color 
    }

}
