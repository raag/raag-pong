using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    public Transform paddle;
    public Rigidbody2D rigidBobyBall;
    public bool gameStarted = false;
    public AudioSource audioSource;
    private float positionDif;

    void Start()
    {
        positionDif = paddle.position.x - (transform.position.x);
    }

    void Update()
    {
        if (!gameStarted) 
        {
            FollowPaddle();
            if (Input.GetMouseButtonDown(0)) {
                StartGame();
            }

        } 
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        audioSource.Play();
    }

    private void FollowPaddle() {
        
        Vector3 newPosition = new Vector3(paddle.position.x - positionDif, paddle.position.y, paddle.position.z);
        transform.position = newPosition;
    }

    private void StartGame() {
        rigidBobyBall.velocity = new Vector2(9, 9);
        gameStarted = true;

    }
}
