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


    
    public void SendMessage()
    {
        string s = "Name: " + namePlayer.text + "\n" + "Email: " + emailPlayer.text + "\n" + "Message: " + messagePlayer.text + "\n" + "Текущее время: " + DateTime.Now + "\n";
       
        using (StreamWriter sw = File.AppendText(@"D:\Work\Alcopoly\Assets\Resources\sendNotes.txt"))
        {
            sw.WriteLine(s);   
        }
    }

}
    

    

