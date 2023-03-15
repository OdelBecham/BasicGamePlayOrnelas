using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.FindWithTag("Player"))
        {
            PlayerStats.lives--;
            Debug.Log("Lives :" + PlayerStats.lives);
        }
        
        if (other.gameObject == GameObject.FindWithTag("Projectile"))
        {
            PlayerStats.score++;
            Debug.Log("Score :" + PlayerStats.score);
        }
        if(PlayerStats.lives < 1)
        {
            Debug.Log("Game Over!");
        }

        Destroy(gameObject);
        Destroy(GameObject.FindWithTag("Projectile"));

       
    }
}
