﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Game Over Canvas that is used for the game
    [Header("Game Over UI Object")]
    public GameObject gameOverCanvas;
    // Game Over Canvas that is used for the game
    [Header("Score UI Object for displaying Score")]
    public GameObject scoreCanvas;
    // Game Over Canvas that is used for the game
    [Header("Spawner Object for spawning objects in game")]
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        // Speed for the game is at a playing state
        Time.timeScale = 1;
        // Make the score visible
        scoreCanvas.SetActive(true);
        // Game Over UI is invisible
        gameOverCanvas.SetActive(false);
        // The spawner is shown in the game
        spawner.SetActive(true);
    }

    public void GameOver() {
        // Game Over UI is visible
        gameOverCanvas.SetActive(true);
        // The spawner is now invisible in the game
        spawner.SetActive(false);
        // The speed for the game is now at a stopping state
        Time.timeScale = 0;
    }
}
