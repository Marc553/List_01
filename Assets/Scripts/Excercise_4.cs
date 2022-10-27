using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Excercise_4 : MonoBehaviour
{
    public GameObject sphere;

    public Slider sizeSlider; //slider that will change size of the sphere

    private Vector3 sphereSize;//value in which the silder will move

    void Start()
    {
        sphereSize = sphere.transform.localScale;
    }

    void Update()
    {
        SliderValue();
       
    }
    public void SliderValue() //put the value of the slider in the sphere size
    {
        float sizeValue;

        sizeValue = sizeSlider.GetComponent<Slider>().value; 
        sphereSize = new Vector3(sizeValue, sizeValue, sizeValue);
    }
}
   
