using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeQuestionsSrc : MonoBehaviour
{
    [SerializeField]
    private Text centerPanel;
    int count = 0;

    
    //ui.GetComponent<UIManager>().WriteText(nameTheme.text);
    List<string> questionsTheme = new List<string>();
    void Start()
    {
        GameObject ui = GameObject.Find("UIManager");
        questionsTheme = ui.GetComponent<UIManager>().questions;
        ChangeQuestion();
    }

    
    public void ChangeQuestion()
    {
        
        centerPanel.text = questionsTheme[count];
        count += 1;
    }
}
