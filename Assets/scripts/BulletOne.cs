using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOne : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //GameObject.FindGameObjectWithTag("Player").SetActive(false);
        }
    }

}
