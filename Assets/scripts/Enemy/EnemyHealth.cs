//using System.Collections;
//using System.Collections.Generic;
//using System;
//using UnityEngine;

//public class EnemyHealth : MonoBehaviour
//{
//    [SerializeField] float health, maxHealth = 2f;


//    public delegate void EnemyKilled();
//    public static event EnemyKilled OnEnemyKilled;
//    public static event Action<EnemyHealth> OnEnemyKilled;

//    private void Start()
//    {
//        health = maxHealth;
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.tag == "Bullet")
//        {
//            TakeDamage(1);
//        }
//    }

//    void TakeDamage(float damageAmount)
//    {

//        health -= damageAmount;

//        if (health <= 0)
//        {
//            Destroy(gameObject);
//            OnEnemyKilled?.Invoke(this);
//        }

//    }

//}
