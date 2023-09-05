using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAtack : MonoBehaviour
{
    private Animator anim;

    public Transform AttackPoint;
    public float attackRangr = 0.5f;
    public LayerMask enemyLayer;
    public int attackDamage = 40;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        AttackLogic();
    }
    private void AttackLogic()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        } 
    }
    private void Attack()
    {
        anim.SetTrigger("Attack");

        Collider2D[] hitEnemy = Physics2D.OverlapCircleAll(AttackPoint.position, attackRangr, enemyLayer); 

        foreach (Collider2D collider in hitEnemy) 
        {
            collider.GetComponent<EnemyAtack>().TakeDamsge(attackDamage);

            Debug.Log("Attack");
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(AttackPoint.position,attackRangr);
    }
}
