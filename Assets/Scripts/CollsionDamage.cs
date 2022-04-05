using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public Animator Animator;   
    public int health = 1;
    void OnTriggerEnter2D()
   {
       Debug.Log("Trigger!!");
       
       Animator.SetBool("Hit", true);

       health --;

       if (health <= 0)
       {
           Die();
       }
   }
 
   void Die()
   {
       Destroy(gameObject);
   }
}

