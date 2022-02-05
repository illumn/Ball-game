using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainLevel : MonoBehaviour
{

    public Button level2;
    public Button level3;
    int LevelComplete;

    // Start is called before the first frame update
    void Start()
    {
        LevelComplete = PlayerPrefs.GetInt("LevelComplete");
        level2.interactable = false;
        level3.interactable = false;

        switch(LevelComplete)
        {
            case 1:
                level2.interactable = true;
                break;
            case 2:
                level2.interactable = true;
                level3.interactable = true;
                break;

        }
    }
         public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        level2.interactable = false;
        level3.interactable = false;
        PlayerPrefs.DeleteAll();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
