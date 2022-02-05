using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Threading;
using UnityEngine.SceneManagement;



public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject PauseButton;

    private void Update()
    {
        if(Time.timeScale == 0)
            PauseButton.SetActive(false);
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        //if (Time.timeScale==0)
        //    PauseButton.SetActive(false);
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseButton.SetActive(true);
    }
    public void Home(int sceneId)

    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneId);

    }

}
