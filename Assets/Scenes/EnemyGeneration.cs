using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{
    float time=0f;
    public GameObject enemyPrefab;
  
    void Update()
    {
        time = time + Time.deltaTime;
        if(time>=4f)
        {
            //print("Enemy generated");
            Vector3 randomPosition = GetPosition();
            Instantiate(enemyPrefab,randomPosition,Quaternion.identity); // Generating Enemies
            time = 0f;
        }
    }
    public Vector3 GetPosition()
    { 
        return new Vector3(Random.Range(Random.Range(-12,-2),Random.Range(2,12)),Random.Range(2,3),Random.Range(Random.Range(-11,2),Random.Range(2,14)));
    }
   
}
