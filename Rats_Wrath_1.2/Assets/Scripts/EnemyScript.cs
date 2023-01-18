using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 10; //maksimalais health
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;  //sak ar maksimalo health
    }
    public void TakeDamage(int damage)  //saprot ka vinam nonemas health
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");  //izsauc animaciju kura ir saistita ar so triggeri
        if(currentHealth <= 0)
        {
            Die();
        }

    }
    void Die()
    {
        Debug.Log("Enemy died!");
        animator.SetBool("isDead", true);  //izsauc animaciju kura ir saistita ar so bool
        GetComponent<Collider2D>().enabled = false;  // kad enemy nomirst vinam nonemas collider
        this.enabled = false; //beigas sis script paliek neaktivs
    }
}
