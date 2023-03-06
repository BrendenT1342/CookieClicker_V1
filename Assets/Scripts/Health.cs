using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 5;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            health--; //Decrease by 1

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }

        //Health colHealth = col.gameObject.GetComponent<Health>();

        //if(colHealth = null )
        //{
            
        //}
    }
}
