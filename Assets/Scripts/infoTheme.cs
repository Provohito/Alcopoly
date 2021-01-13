using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;


public class infoTheme : MonoBehaviour
{
    
    public GameObject colorImage;
    public Color highlightedColor;
    
    
    Text nameTheme;
    private GameObject ui;
    bool isTurned;
    

    public void Start()
    {
        
        
        ui = GameObject.Find("UIManager");
    }
    public void Update()
    {
        
    }
    public void ChooseTheme()
    {
        if (isTurned == false)
        {
            highlightedColor.a = 1;
            colorImage.GetComponent<Image>().color = highlightedColor;

            nameTheme = this.gameObject.transform.Find("nameTheme").gameObject.GetComponent<Text>();

            ui.GetComponent<UIManager>().WriteText(nameTheme.text);
            isTurned = true;
        }
        else
        {
            ui.GetComponent<UIManager>().ClearList();
            ResetTopicColor();
            isTurned = false;
        }

        

    }
    // File.AppendText(@"D:\Work\Alcopoly\Assets\Resources\sendNotes.txt"
    public void ResetTopicColor()
    {
        colorImage.GetComponent<Image>().color = Color.white;
    }


}
