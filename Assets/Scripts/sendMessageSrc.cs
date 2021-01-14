using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class sendMessageSrc : MonoBehaviour
{
    [SerializeField]
    private Text namePlayer;
    [SerializeField]
    private Text emailPlayer;
    [SerializeField]
    private Text messagePlayer;
    [SerializeField]
    private GameObject errorpanel;


    
    public void SendMessage()
    {
        GameObject ui = GameObject.Find("UIManager");
        if (namePlayer.text != "" & emailPlayer.text!= "" & messagePlayer.text != "")
        {
            
            string s = "Name: " + namePlayer.text + "\n" + "Email: " + emailPlayer.text + "\n" + "Message: " + messagePlayer.text + "\n" + "Текущее время: " + DateTime.Now + "\n";

            string path = "Assets/Resources/messages.txt";

            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(s);
            writer.Close();

            
            
            ui.GetComponent<UIManager>().nameUI = "addPlayerPanel";
            // отправка не мменяет сцену из-за simple///
        }
        else
        {
            ui.GetComponent<UIManager>().nameUI = "errorPanelsend";
        }
        
    }

}
    

    

