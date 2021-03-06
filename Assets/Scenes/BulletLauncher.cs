using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    Rigidbody rb;
    public float speed;
    public int score;
    public float checkTime;
   
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject tempBullet=Instantiate(bulletPrefab, transform.position,Quaternion.identity); // Instantiating Bullets
 
            rb = tempBullet.GetComponent<Rigidbody>();
            tempBullet.transform.position = transform.position;
           // Camera camera = GetComponentInChildren<Camera>();
            rb.velocity=Camera.main.transform.rotation* (Vector3.forward * speed);
            
        }
        // Win Condition Checking
        // Game will end in 1 minute
        checkTime = checkTime + Time.deltaTime;
        if (score == 10 && checkTime < 60f)
            Debug.Log("Player is the Winner");
        else if(score<10 && checkTime>60f)
            Debug.Log("GameOver! \n Player loss the game");
        if (checkTime > 60f)
        {
         
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Loading the scene after game ends.
        }

    }
  
}
