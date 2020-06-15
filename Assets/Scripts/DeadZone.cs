using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeadZone : MonoBehaviour
{
    public Text scorePlayerText;
    public Text scoreCPUText;

    private int scorePlayer;
    private int scoreCPU;
    public Router router;
    public AudioSource audioSource;

    private const string WIN_SCENE_NAME = "WinScene";
    private const string LOSE_SCENE_NAME = "LoseScene";

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (gameObject.CompareTag("Left"))
        {
            scoreCPU ++;
            UpdateScoreLabel(scoreCPUText, scoreCPU);
        }
        else if (gameObject.CompareTag("Right")) 
        {
            scorePlayer ++;
            UpdateScoreLabel(scorePlayerText, scorePlayer);
        }

        BallBehaviour ball = collision.GetComponent<BallBehaviour>();
        ball.gameStarted = false;

        CheckScore();

        audioSource.Play();
    }

    private void UpdateScoreLabel(Text label, int score) {
        label.text = score.ToString();
    }

    private void CheckScore()
    {
        if (scorePlayer >= 3) 
        {
            router.ShowScene(WIN_SCENE_NAME);
        }
        else if (scoreCPU >= 3) 
        {
            router.ShowScene(LOSE_SCENE_NAME);
        }
    }
}
