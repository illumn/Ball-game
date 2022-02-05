using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public GameObject LoadingScren;
    public Slider scale;


    public void Loading()
    {
        LoadingScren.SetActive(true);
        StartCoroutine(LoadAsync());
    }
    IEnumerator LoadAsync()
    {
        AsyncOperation LoadAsync = SceneManager.LoadSceneAsync(1);
        LoadAsync.allowSceneActivation = false;
        while(!LoadAsync.isDone)
        {
            scale.value = LoadAsync.progress;
            if(LoadAsync.progress>-.9f&& !LoadAsync.allowSceneActivation)
            {
                yield return new WaitForSeconds(20f);
                LoadAsync.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
