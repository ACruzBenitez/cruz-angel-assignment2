using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    private float elapsed = 0f;

    // Update is called once per frame
    void Update()
    {
         elapsed += Time.deltaTime;
        if (elapsed >= 4f)
        {
        transform.Rotate(0.0f, 0.0f, 180.0f); 
        elapsed = elapsed % 1f;
        }
    }
}
