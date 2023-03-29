using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int yPos;
    public int enemyCount;
    public int xMin, xMax, zMin, zMax;

    void Update()
    {
        if (enemyCount == 10)
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(EnemyDrop());
        }
    }

    IEnumerator EnemyDrop()
    {
        for (int i = 0; i < 10; i++)
        {
            xPos = Random.Range(xMin, xMax);
            zPos = Random.Range(zMin, zMax);
            Instantiate(enemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }

}
