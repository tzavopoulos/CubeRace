using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gamemanager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 5f;

    public GameObject ui;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("Restart", restartDelay);


        }
    }
    public void CompleteGame()
    {
        ui.SetActive(true);
     }

    public void Restart()
    {
        SceneManager.LoadScene("Level01");

    }

    private int score;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        scoreText.text = "Score: " + score;
    }
}