using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameObject WinMenu;
    [SerializeField] GameObject PauseButton;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            PauseButton.SetActive(false);
            WinMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
