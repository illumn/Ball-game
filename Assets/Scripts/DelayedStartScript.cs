using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedStartScript : MonoBehaviour
{
    [SerializeField] GameObject ResumeMenu;
    public GameObject countDown;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("StartDelay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float pasuseTime = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup <pasuseTime)
            yield return  0;
        countDown.gameObject.SetActive(false);
        ResumeMenu.gameObject.SetActive(true);
        Time.timeScale = 1;

    }
}
