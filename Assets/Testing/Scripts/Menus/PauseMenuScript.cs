using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _resumeButton;

    public void StartGame() {  
        SceneManager.LoadScene(1); 
    }

    public void ExitGame() {  
        Debug.Log("QUIT");  
        Application.Quit(); 
    }

    public void Menu() {  
        SceneManager.LoadScene(0);
    }

    public void PauseButton() {  
        Time.timeScale = 0f;
        _resumeButton.SetActive(true);
        _pauseButton.SetActive(false);
    }

    public void ResumeButton() {  
        Time.timeScale = 1.0f;
        _resumeButton.SetActive(false);
        _pauseButton.SetActive(true);
    }
}
