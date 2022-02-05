using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] GameObject WinMenu;
    [SerializeField] GameObject pauseButton;

    //private void OnTriggerEnter(Collider other)
    //{
    //    LevelController.instance.isEndGame();
    //}
    public void Win()

    {
        //WinMenu.SetActive(true);
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
    }

}