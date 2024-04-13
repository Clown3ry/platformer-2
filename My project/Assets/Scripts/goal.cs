using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    //called when a collision is detected 
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))  //if the object colliding with id the player
        {
            SceneManager.LoadScene("Level12");      //move to the level12
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
