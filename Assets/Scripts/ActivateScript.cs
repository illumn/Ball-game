using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateScript : MonoBehaviour
{
    [SerializeField] GameObject Object;
    [SerializeField] GameObject ResumeMenu;



    void Start()
    {
        gameObject.SetActive(true);
        Object.SetActive(true);
        ResumeMenu.SetActive(false);
    }
    void Update()
    {


    }
}
