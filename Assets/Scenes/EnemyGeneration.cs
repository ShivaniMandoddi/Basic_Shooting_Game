using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{
    float time=0f;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if(time>=4f)
        {
            print("Enemy generated");
            Vector3 randomPosition = GetPosition();
            Instantiate(enemyPrefab,randomPosition,Quaternion.identity);
            time = 0f;
        }
    }
    public Vector3 GetPosition()
    { 
        return new Vector3(Random.Range(-12,12),Random.Range(1,4),Random.Range(-11,14));
    }
   
}
