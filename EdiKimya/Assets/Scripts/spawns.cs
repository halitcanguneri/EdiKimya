using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawns : MonoBehaviour
{

    [SerializeField] GameObject[] glassPrefab;
    [SerializeField] float secondSpawn = 1.0f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    void Start()
    {
        StartCoroutine(spawner());
        
    }

    IEnumerator spawner()
    {
        while(true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(glassPrefab[Random.Range(0, glassPrefab.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 9f);
        }

    }























}


//public GameObject yesilBeherglas,k�rm�z�Beherglas;
//public float respawnTimeYesil = 1.0f;
//public float respawnTimeK�rm�z� = 2.0f;
//private Vector2 screenBounds;

//// Use this for initialization
//void Start()
//{
//    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
//    StartCoroutine(asteroidWave());
//}
//private void spawnEnemyYES�L()
//{
//    GameObject a = Instantiate(yesilBeherglas) as GameObject;
//    a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y);
//}
//private void spawnEnemyKIRMIZI()
//{
//    GameObject a = Instantiate(k�rm�z�Beherglas) as GameObject;
//    a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y);
//}
//IEnumerator asteroidWave()
//{
//    while (true)
//    {
//        yield return new WaitForSeconds(respawnTimeYesil);
//        spawnEnemyYES�L();
//        yield return new WaitForSeconds(respawnTimeK�rm�z�);
//        spawnEnemyKIRMIZI();
//    }
//}