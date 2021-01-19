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

    [SerializeField]
    private InputField _namePlayer;
    [SerializeField]
    private InputField _emailPlayer;
    [SerializeField]
    private InputField _messagePlayer;
    [SerializeField]

    public void ResetText()
    {
        _namePlayer.text = "Ваше имя";
        _emailPlayer.text = "Ваша почта";
        _messagePlayer.text = "Сообщение";
    }



    public void SendMessage()
    {
        GameObject ui = GameObject.Find("UIManager");
        if ((namePlayer.text != "" & emailPlayer.text!= "" & messagePlayer.text != "") & (namePlayer.text != "Ваше имя" & emailPlayer.text != "Ваша почта" & messagePlayer.text != "Сообщение"))
        {
            
            /*string s = "Name: " + namePlayer.text + "\n" + "Email: " + emailPlayer.text + "\n" + "Message: " + messagePlayer.text + "\n" + "Текущее время: " + DateTime.Now + "\n";

            string path = "Assets/Resources/messages.txt";

            var textFile = Resources.Load("Text/messages") as TextAsset;
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(s);
            writer.Close();*/
            
            
            ui.GetComponent<UIManager>().nameUI = "addPlayerPanel";
            
            
        }
        else
        {
            ui.GetComponent<UIManager>().nameUI = "errorPanelsend";
        }
        
    }

    

}
    

    

