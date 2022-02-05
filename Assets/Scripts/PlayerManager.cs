using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    
    public static bool GameOver;
    [SerializeField]
    GameObject GameOverPanel;
    [SerializeField]
    GameObject PauseButton;
    public GameObject[] CharacterPrefabs;
    public Transform spawn;
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = CharacterPrefabs[selectedCharacter];
        GameObject clone = Instantiate(prefab,spawn.transform.position,Quaternion.identity);
       
            Debug.Log(prefab.name);
    }

    public void GameoverPanel()
    {
        GameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        PauseButton.SetActive(false);
        
    }
}