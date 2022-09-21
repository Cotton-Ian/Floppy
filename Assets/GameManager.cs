using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanevas;

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver() {
        GameOverCanevas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay() {
        SceneManager.LoadScene(1);
    }

}
