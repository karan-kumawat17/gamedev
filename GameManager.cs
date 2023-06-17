using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject AsteroidPrefab;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("InstantiateEnemy",1f,5f);
        InvokeRepeating("InstantiateAsteroid",1f,3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateEnemy(){
        Vector3 enemyPos = new Vector3(Random.Range(-8.5f,8.5f),4.5f,0);
        GameObject enemy = Instantiate(EnemyPrefab, enemyPos, Quaternion.Euler(0,0,Random.Range(-180f,180f)));
        Destroy(enemy, 10f);
    }

    void InstantiateAsteroid(){
        Vector3 AsterPos = new Vector3(Random.Range(-8.5f,8.5f),4.5f,0);
        GameObject aster = Instantiate(AsteroidPrefab, AsterPos, Quaternion.Euler(0,0,Random.Range(-180f,180f)));
        Destroy(aster, 15f);
    }
}
