using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

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

            string sMessage = "Name: " + namePlayer.text + "\n" + "Email: " + emailPlayer.text + "\n" + "Message: " + messagePlayer.text + "\n" + "Текущее время: " + DateTime.Now + "\n";
            /*
            string path = "Assets/Resources/messages.txt";

            var textFile = Resources.Load("Text/messages") as TextAsset;
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(s);
            writer.Close();*/

            MailAddress from = new MailAddress("zigola12@gmail.com", "Alex");
            // кому отправляем
            MailAddress to = new MailAddress("tech@techin.by");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Alex";
            // текст письма
            m.Body = sMessage;
            // письмо представляет код html
           
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("zigola12@gmail.com", "semka888");
            smtp.EnableSsl = true;
            smtp.Send(m);

            ui.GetComponent<UIManager>().nameUI = "addPlayerPanel";
            
            
        }
        else
        {
            ui.GetComponent<UIManager>().nameUI = "errorPanelsend";
        }
        
    }

    

}
    

    

