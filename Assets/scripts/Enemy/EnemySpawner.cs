using System.Collections;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] private float spawnRate = 4f;
    [SerializeField] int spawns = 0;
    private int xPos;
    private int zPos;

    private int spawnsLimit = 4;
    

    private void Start()
    {
            StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {

        if (GameObject.FindGameObjectsWithTag("Enemy").Length < spawnsLimit)
        {
            xPos = Random.Range(-20, 20);
            zPos = Random.Range(-20, 20);
            Instantiate(enemyPrefab, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(4f);
            StartCoroutine(EnemySpawn());
        }
    }
   

}
