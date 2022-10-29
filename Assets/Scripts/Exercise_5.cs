using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    public GameObject targetPrefab; //capusle that will spawn 
    public Vector3[] targetPositions; //all the random positions 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) //if "s" is pressed execute the function
        {
            Spawn();
        }
    }

       public void Spawn() // function that start the spawn
       { 
        for (int i = 0; i < targetPositions.Length; i++) //pass all the numbers 1 by 1 to the end of the target Position
        {
            Instantiate(targetPrefab, targetPositions[i], targetPrefab.transform.rotation); //spawn a capsule where the target positon says(that is changing because the "for")

        }

       }
    
        

  
}
