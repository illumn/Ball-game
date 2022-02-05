using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeEventi : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(waiter());
        //Time.timeScale = 1;
    }

    IEnumerator waiter()
    {

        //Wait for 4 seconds
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 1;


    }
}