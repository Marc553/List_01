using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_6 : MonoBehaviour
{
    public Material[] colorCylinder;
    public GameObject cylinder;

    public void DropdownSlection(int selection)
    {
        cylinder.GetComponent<Renderer>().material = colorCylinder[selection]; 
    }

}
