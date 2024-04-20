using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;         //static variable that will hold singleton

    //called when script is being loaded
    void Awake()
    {
        //make a singleton to prevent more than one instance of an object 
        if (Instance == null) {             //if instance  hasn't been set
            DontDestroyOnLoad(gameObject);  //don't destroy object when loading new scene
            Instance = this;                //set instance to this object 

        }

        else                               //if instance is set to an object
        {
            Destroy(gameObject);            //destroy this 
        }
    }
        
  
}
