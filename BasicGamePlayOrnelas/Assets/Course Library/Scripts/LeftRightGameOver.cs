using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightGameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(GameObject.FindWithTag("Farmer"))
        {
            Debug.Log("Game Over");
        }
    }
}
