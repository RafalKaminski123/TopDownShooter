using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    [SerializeField] GameObject BulletPrefab;
    [SerializeField] Transform BulletSpawn;

    private float shootingRate = 1f;
    private float timeStamp = 0f;


    private void Update()
    {
        if (Time.time >= timeStamp)
        {
            Fire();
            timeStamp = Time.time + shootingRate;
        }
    }

    void Fire()
    {
        var bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 15;


        Destroy(bullet, 2.0f);

    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Destroy(other.gameObject);
    //    }
    //}




}
