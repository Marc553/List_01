using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_7 : MonoBehaviour
{
    public GameObject sphere;

    public void ChangeAlpha(float alphaVal)
    {   
        Color oldColor = sphere.GetComponent<Renderer>().material.color;
        oldColor.a = alphaVal;
        sphere.GetComponent<Renderer>().material.color = oldColor;
        
    }

}