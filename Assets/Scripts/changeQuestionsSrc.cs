using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeQuestionsSrc : MonoBehaviour
{
    [SerializeField]
    private Text centerPanel;
    [SerializeField]
    private Text namePlayerText;
    int count = 0;
    List<string> simpleList = new List<string>();

    
    public void Ckicking(ParticleSystem value)
    {
        value.Play();
    }

    //ui.GetComponent<UIManager>().WriteText(nameTheme.text);
    List<string> questionsTheme = new List<string>();
    void Start()
    {
        GameObject ui = GameObject.Find("UIManager");
        questionsTheme = ui.GetComponent<UIManager>().questions;
        simpleList = ui.GetComponent<UIManager>().namePlayer;
        ChangeQuestion();
        
    }

    
    public void ChangeQuestion()
    {
        GameObject ui = GameObject.Find("UIManager");
        if (questionsTheme.Count == count)// будет равен определённому числу
        {
            
            ui.GetComponent<UIManager>().nameUI = "endQuestions";
            count = 0;
        }
        namePlayerText.text = simpleList[Random.Range(0, simpleList.Count)];
        centerPanel.text = questionsTheme[count];
        if (centerPanel.text.Contains("{Player}"))
        {
            
            centerPanel.text = centerPanel.text.Replace("{Player}", namePlayerText.text);
            count += 1;
        }
        else
        {
           
            namePlayerText.text = "";
            count += 1;
        }
        

        
        
    }
}
