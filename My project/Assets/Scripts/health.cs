using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //variables for the game
    public int maxHealth;       //determines max amount of health the player can have
    public int currentHeath;    //tracks current health of the player

    public GameObject hp1;
        


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 1;            //set max health to 1
        currentHeath = maxHealth;   //set current health to max health
    }

    public void TakeDamage(int amount)
    {
        currentHeath -= amount;                 //lower health

   
        if (currentHeath == 1) 
        {
          hp1.SetActive(false);
        }

        if (currentHeath <= 0)              //if health equals zero
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
