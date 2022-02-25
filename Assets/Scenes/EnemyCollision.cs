using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private float time;
    void Update()
    {
        time = time + Time.deltaTime; // TO destroy enemy for every 5s 
        if(time>5f)
        {
            Destroy(gameObject);
            time = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet") // Destroying enemy after colliding with bullet
        {
            Destroy(gameObject);
            GameObject.Find("Player").GetComponent<BulletLauncher>().score++;
        }
    }

}
