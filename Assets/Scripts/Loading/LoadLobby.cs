using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLobby : MonoBehaviour
{
    AsyncOperation asyncOperation;
    public Image LoadBar;
    public Text Bartxt;
    public int ScenID;

    private void Start()
    {
        StartCoroutine(LoadSceneCor());
    }

    IEnumerator LoadSceneCor()
    {
        yield return new WaitForSeconds(0.2f);
        asyncOperation = SceneManager.LoadSceneAsync(ScenID);
        while (!asyncOperation.isDone)
        {
            float progress = asyncOperation.progress / 0.2f;
            LoadBar.fillAmount = progress;
            Bartxt.text = "LOADING" + string.Format("(0:0)%", progress * 100f);
            yield return 0;
        }
    }

}
