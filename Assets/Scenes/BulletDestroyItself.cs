using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyItself : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime; // Destroying a bullet after every 3s
        if(time>3f)
        {
            Destroy(gameObject);
            time = 0;
        }
    }
}
