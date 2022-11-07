using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField] GameObject BulletPrefab;
    [SerializeField] Transform BulletSpawn;

    private float shootingRate = 0.5f;
    private float timeStamp = 0f;


    private void Update()
    {
        if ((Time.time >= timeStamp) && (Input.GetMouseButtonDown(0)))
        {
            Fire();
            timeStamp = Time.time + shootingRate;
        }
    }

    void Fire()
    {
        var bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 25;

        Destroy(bullet, 2.0f);

    }




}
