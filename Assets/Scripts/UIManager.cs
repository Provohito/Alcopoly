﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Image fillground;
    private string _nameUI;
    public string nameUI
    {
        get {return _nameUI;}
        set { _nameUI = value;}
    }

    string simpleVariable;

    
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            StartCoroutine("FirstLoad");
        }
        if (_nameUI != null)
        {
            NextLevel(_nameUI);
        }
    }
    IEnumerator FirstLoad()
    {
        for (float ft = fillground.fillAmount; ft <= 1; ft += 0.0025f)
        {
            fillground.fillAmount += ft;
            yield return new WaitForSeconds(.1f);
            if(fillground.fillAmount == 1)
            {
                GameObject Namelevel = GameObject.Find("[Interface]/CanvasRoot/alertPanel");
                simpleVariable = Namelevel.name;
                Debug.Log(simpleVariable);
                Namelevel.SetActive(true);
                Namelevel = GameObject.Find("[Interface]/CanvasRoot/loadPanel");
                Namelevel.SetActive(false);
                StopAllCoroutines(); 
            }
        }
    }

    void NextLevel(string name)
    {
        GameObject Namelevel = GameObject.Find("[Interface]/CanvasRoot/" + simpleVariable);
        Namelevel.SetActive(false);
        Namelevel = GameObject.Find("[Interface]/CanvasRoot/"+ name );
        Namelevel.SetActive(true);
        simpleVariable = name;
    }
    
}
