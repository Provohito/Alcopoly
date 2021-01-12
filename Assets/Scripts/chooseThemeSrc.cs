using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chooseThemeSrc : MonoBehaviour
{

    private GameObject[] topics;
    private bool _isReset;
    public bool isReset
    {
        get {return _isReset; }
        set {_isReset = value; }
    }
    public void Start()
    {
        topics = GameObject.FindGameObjectsWithTag("Theme");
        
    }
    public void Update()
    {
        if (_isReset == true)
        {
            ResetTopic();
            _isReset = false;
        }
    }
    void ResetTopic()
    {
        for (int i = 0; i < topics.Length; i++)
        {
            topics[i].GetComponent<infoTheme>().ResetTopicColor();
        }

    }
}
