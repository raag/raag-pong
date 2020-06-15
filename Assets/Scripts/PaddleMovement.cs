using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    const float MIN_SCREEN_Y = -3.8f;
    const float MAX_SCREEN_Y = 3.8f;
    void Start()
    {
        
    }

    void Update()
    {
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        float x = transform.position.x;
        float z = 10;
        float y = Mathf.Clamp(mousePosition.y, MIN_SCREEN_Y, MAX_SCREEN_Y);
        
        transform.position = new Vector3(x, y, z);
    }
}
