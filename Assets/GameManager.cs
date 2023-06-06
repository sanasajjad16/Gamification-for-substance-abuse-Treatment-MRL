using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int points;
    public static int currentScene;

    private void Awake()
    {
        Debug.Log("GameManager AWAKE()");
        instance = this;
        points = 0;
        currentScene = 0;
    }

    void Start()
    {
        LoadNewLevel();
    }

    public void onFinishLevel()
    {
        LoadNewLevel();
    }

    public void LoadNewLevel()
    {
        if (currentScene < 3)
        {
            ResetPoints();
            currentScene += 1;
            SceneManager.LoadScene(currentScene);
        }
        else
        {
            GameOver();
        }
    }

    public void ResetPoints()
    {
        points = 0;
    }

    public void GameOver()
    {

    }
}
