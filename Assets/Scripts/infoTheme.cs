using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;


public class infoTheme : MonoBehaviour
{
    
    public GameObject colorImage;
    
    
    
    Text nameTheme;
    private GameObject ui;
    bool isTurned;

    [SerializeField]
    private GameObject setChoose;

    public void Start()
    {
        
        
        ui = GameObject.Find("UIManager");
    }
    public void Update()
    {
        
    }
    public void ChooseTheme()
    {
        
        if (setChoose.activeSelf == false)
        {
            isTurned = false;
        }
        if (isTurned == false)
        {
            setChoose.SetActive(true);
            nameTheme = this.gameObject.transform.Find("nameTheme").gameObject.GetComponent<Text>();

            ui.GetComponent<UIManager>().WriteText(nameTheme.text);
            isTurned = true;
        }
        else
        {
            setChoose.SetActive(false);
            ui.GetComponent<UIManager>().ClearList();
            ResetTopicColor();
            isTurned = false;
        }

        

    }

    public void ResetTopicColor()
    {
        
        setChoose.SetActive(false);
    }


}
