using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ballPosition;
    public float speed;


    void Start()
    {
        
    }

    void Update()
    {
        BallBehaviour ball = ballPosition.GetComponent<BallBehaviour>();
        if (ball.gameStarted) 
        {
            if (transform.position.y < ballPosition.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            }
            else if (transform.position.y > ballPosition.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
            }
        }        
    }
}
