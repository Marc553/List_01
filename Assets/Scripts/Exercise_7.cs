using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_7 : MonoBehaviour
{
    public GameObject sphere;//sphere

    public void ChangeAlpha(float alphaVal)// function that changes the alpha of the sphere 
    {   
        Color oldColor = sphere.GetComponent<Renderer>().material.color;//get the actual color(alpha)
        oldColor.a = alphaVal;//conects the alpha with the float of the function
        sphere.GetComponent<Renderer>().material.color = oldColor; //sets the color(alpha) of the sphere with the changed alpha(with the float of the alphaVal
        
    }

}