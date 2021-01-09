using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
    
}
