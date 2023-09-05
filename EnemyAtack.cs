using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private float Speed = 0.02f;
    public int EnemyHP = 100;
    private int currentHealth;
    private Animator anim;

    private void Start()
    {
        currentHealth = EnemyHP;
        anim = GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AminOff();
            Debug.Log("Y target from Enemy");
            anim.SetBool("Attack", true);
            transform.position = Vector2.MoveTowards(transform.position, Player.position, Speed);
        }
    }
    public void TakeDamsge(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            AminOff();
            anim.SetBool("Attack", false);
            anim.SetBool("Deade", true);
            Debug.Log("EnemyDead");
        }
        else
        {
            anim.SetBool("Deade", false);
        }
    }

    private void AminOff()
    {
        Destroy(GetComponent<EnemyMove>());
        anim.SetBool("Run", false);
        anim.SetBool("Run2", false);
        anim.SetBool("Run3", false);
        anim.SetBool("Run4", false);
    }
}
