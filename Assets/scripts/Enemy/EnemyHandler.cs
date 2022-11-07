using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 2f;
    [SerializeField] float EnemySpeed;
    [SerializeField] EnemySpawner enemySpawner;

    private Transform playerPos;


    void Awake()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        EnemyMove();
    }
    void EnemyMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, EnemySpeed * Time.deltaTime);
        transform.LookAt(playerPos);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(float damageAmount)
    {

        health -= damageAmount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }



}
