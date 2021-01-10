using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Flags]
public enum Infosrc
{
    first = 1,
    second,
    third
}
public class infoTheme : MonoBehaviour
{
    public Infosrc info;
    public GameObject qwe;
    public GameObject ewq;
    List<string> questions = new List<string>();
    string path = @"D:\Work\Alcopoly\Assets\Resources\questions.txt";

public void Chadfsa()
    {
        switch (info)
        {
            case Infosrc.first:
                qwe.SetActive(true);
                break;
            case Infosrc.second:
                ewq.SetActive(true);
                break;
            default:
                break;
        }
    }
    // File.AppendText(@"D:\Work\Alcopoly\Assets\Resources\sendNotes.txt"
    public void WriteText()
    {
        using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                questions.Add(line);
                Debug.Log(line);

            }
        }
        Debug.Log(questions.Count);
    }
}
