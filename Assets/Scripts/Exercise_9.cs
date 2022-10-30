using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Exercise_9 : MonoBehaviour
{

    public Light lamp;//get the ligth

    public Toggle onOff;//get the toggle

    public void OnOff()//function that on/off the ligth with the toggle 
    {
        lamp.enabled = onOff.isOn;//on/off the ligths with the toggle
        
    }
}
