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

            using (StreamWriter sw = File.AppendText(@"D:\Work\Alcopoly\Assets\Resources\sendNotes.txt"))
            {
                sw.WriteLine(s);
            }
            
            ui.GetComponent<UIManager>().nameUI = "addPlayerPanel";
            // отправка не мменяет сцену из-за simple///
        }
        else
        {
            ui.GetComponent<UIManager>().nameUI = "errorPanelsend";
        }
        
    }

}
    

    

