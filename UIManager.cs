using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject pauseButton;

    private void Awake()
    {
        Time.timeScale = 0;

        startPanel.SetActive(true);

        pauseButton.SetActive(false);
        pausePanel.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1;

        startPanel.SetActive(false);

        pauseButton.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;

        pauseButton.SetActive(false);

        pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;

        pausePanel.SetActive(false);

        pauseButton.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);

        pausePanel.SetActive(false);
    }
}
