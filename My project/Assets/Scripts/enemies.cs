using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemies : MonoBehaviour
{
    //variables for the game
    Health damage;

    public GameObject hitPoints;

    //Vector2 direction;

    public float speed;
    public bool left = true;

    // Start is called before the first frame update
    void Start()
    {
        damage = hitPoints.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "spike" && left)
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        }
        else if (gameObject.tag == "spike" && left)
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }
        if (gameObject.tag =="Fly")
        {
            Distance = Vector2.Distance(transform.position, Playermovement.transform.position);
        }
        if (left)
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            damage.TakeDamage(1);
        }

        if (collision.tag == "wall"&& left == true) 
        {
            left = false;        
        }

        else if (collision.tag == "wall"&& left==false) 
        {
            left = true;
        }
    }
}
