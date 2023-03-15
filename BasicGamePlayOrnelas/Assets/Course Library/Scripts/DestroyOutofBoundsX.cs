using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBoundsX : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -30;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
