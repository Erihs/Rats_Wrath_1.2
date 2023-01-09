using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator; //pievieno animatora logu pie scripta ko var redzet inspektora

    public Transform Attackpoint;  //norada kur ir attackpoints
    public LayerMask enemyLayer;  //atlasa Enemy layeru lai zinatu kam uzbrukt

    public float attackRange = 0.4f;   //norada kads ir range
    public int attackDamage = 3;

    public float attackRate = 2f;  //pievieno uzbrukumam cooldodwn, lai nevaretu spamot uzbrukumu visu laiku
    float nextAttackTime = 0f;

    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))  //izmanto keybind
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
       
    }
    void Attack()
    {
        animator.SetTrigger("Attack");  //izpilda animaciju
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(Attackpoint.position, attackRange, enemyLayer);  //saprot vai ir Enemy taja uzbrukuma apli
        foreach(Collider2D enemy in hitEnemies)  //izdara damage prieks enemy
        {
            enemy.GetComponent<EnemyScript>().TakeDamage(attackDamage);  //nosuta damage uz enemy script, lai tas saprot ka vinam uzbruk
        }
    }
}
