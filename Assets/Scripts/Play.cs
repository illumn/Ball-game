using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Play : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;

    private void Start()
    {
        Time.timeScale = 0;
    }
    public void Pause()

    {
        pauseMenu.SetActive(true);

        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);

        //int i;

        //for (i = 0; i <= 1000; i++)
        //    if (i == 700)
        //        resumeCanvas();
        //Thread.Sleep(5000);
        //Debug.Log(i);
    }
    public void resumeCanvas()
    {
        
        //Thread.Sleep(1500);
        Time.timeScale = 1;
    }
}
