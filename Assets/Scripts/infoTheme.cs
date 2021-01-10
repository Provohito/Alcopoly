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

    public void ChooseTheme()
    {
        highlightedColor.a = 1;
        colorImage.GetComponent<Image>().color = highlightedColor;
        
        GameObject ui = GameObject.Find("UIManager");

        nameTheme = this.gameObject.transform.Find("nameTheme").gameObject.GetComponent<Text>();

        ui.GetComponent<UIManager>().WriteText(nameTheme.text);

    }
    // File.AppendText(@"D:\Work\Alcopoly\Assets\Resources\sendNotes.txt"

}
