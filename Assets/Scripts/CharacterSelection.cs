using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    public GameObject[] characters;
    public int selectedCharacter = 0;
    

    //void Start()
    //{
    //    int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
    //    GameObject prefab = CharacterPrefabs[selectedCharacter];
    //    GameObject clone = Instantiate(prefab, SpawnPoint.position, Quaternion.identity);
    //    Debug.Log(prefab.name);

    //}
    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter+1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }
    public void PreviousCharater()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter<0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }
    public void ReturnHome()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
