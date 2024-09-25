using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float healthPoints;
    public Animator anim;  

    public void TakeDamage(float damagePoints)
    {
        healthPoints -= damagePoints;
        if (healthPoints <= 0)
        {
            //Die
        }
        else
        {
            anim.SetTrigger("Hit");
        }
    }
}
