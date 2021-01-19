using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;





public class UIManager : MonoBehaviour
{
    

    [HideInInspector]
    public List<string> namePlayer = new List<string>();
    [SerializeField]
    private Scrollbar scrollbar;
    private string _nameUI;
    bool attantionCount;

    string path1 = "Text/18+";
    string path2 = "Text/Первоя пошла";

    public string nameUI
    {
        get {return _nameUI;}
        set { _nameUI = value;}
    }
    [HideInInspector]
    public string simpleVariable;

    
    public List<string> questions = new List<string>();
    
    string nameTheme;
    List<string> theme1 = new List<string>();
    List<string> theme2 = new List<string>();
    

    [SerializeField]
    private GameObject attentionWindowQuestions;

    List<string> firstListLoad = new List<string>();
    [SerializeField]
    public Text firstLoadText;

    [SerializeField]
    private GameObject attentionWindowTheme;

    [HideInInspector]
    public GameObject[] allThemes;

    [SerializeField]
    private GameObject chooseThemePanel;

    [SerializeField]
    private GameObject attentionWindowCompletedMessage;
    
    

    private void Start()
    {
        LoadFirstText();
        StartCoroutine(FirstLoad());
        LoadThemes(theme1, path1);
        LoadThemes(theme2, path2);

    }

    void Update()
    {
        scrollbar.value = 0;
        if (_nameUI != null)
        {
            NextLevel(_nameUI);
        }

    }
    public void CheckFubction(string value)
    {
        if (namePlayer.Count != 0 & value == "chooseTheme" & attantionCount == false)
        {
            nameUI = value;
            StopAllCoroutines();
            
        }
        else if (value == "chooseTheme")
        {
            attantionCount = true;
            StartCoroutine(AttentionPanel(attentionWindowQuestions));
            
        }
            

        if (questions.Count != 0 & value == "questionsPanel" & attantionCount == false)
        {
            nameUI = value;
            StopAllCoroutines();
            
        }
        else if (value == "questionsPanel")
        {
            attantionCount = true;
            StartCoroutine(AttentionPanel(attentionWindowTheme));
            
        }
        if (value == "addPlayerPanel")
        {
            StartCoroutine(AttentionPanel(attentionWindowCompletedMessage));
        }  

    }

    IEnumerator AttentionPanel(GameObject activeObject)
    {
        activeObject.SetActive(true);
 
        yield return new WaitForSeconds(2f);

        activeObject.SetActive(false);
        attantionCount = false;
        StopAllCoroutines();
    }
    IEnumerator FirstLoad()
    {
         
        yield return new WaitForSeconds(3f);
        for (float ft = scrollbar.size; ft <= 1; ft += 0.0025f)
        {
            scrollbar.size += ft;
            yield return new WaitForSeconds(.05f);
            if(scrollbar.size == 1)
            {
                GameObject Namelevel = GameObject.Find("[Interface]/CanvasRoot/alertPanel");
                simpleVariable = Namelevel.name;
                
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
        _nameUI = null;
    }
    
    public void SetValueStruct(string value)
    { 
        SaveName(value);
        
    }

    void SaveName(string value)
    {
        
        namePlayer.Add(value);
    }

    public void DeleteName(string value)
    {
        for (int i = 0; i < namePlayer.Count; i++)
        {
            if (namePlayer[i] == value)
            {
                namePlayer.Remove(value);
            }
        }
    }
    private void LoadThemes(List<string> valueList, string valuePath)
    {
        var textFile = Resources.Load(valuePath) as TextAsset;
        string[] s = textFile.text.Split(';');
        foreach (var item in s)
        {
            valueList.Add(item);
        }
    }
    private void LoadFirstText()
    {
        var textFile = Resources.Load("Text/FirstLoad") as TextAsset;
        string[] s = textFile.text.Split(';');
        foreach (var item in s)
        {
            firstListLoad.Add(item);
        }
        firstLoadText.text = firstListLoad[UnityEngine.Random.Range(0, firstListLoad.Count)];
    }

    public void WriteText(string value)
    {
        nameTheme = value;
        
        if (value == "18+")
        {
            foreach (var item in theme1)
            {
                questions.Add(item);
            }
        }
        else
        {
            foreach (var item in theme2)
            {
                questions.Add(item);
            }
        }
        
    }

    public void wqe()
    {
        for (int i = 0; i < questions.Count; i++)
        {
            Debug.Log(questions[i]);
        }
    }   
    public void ClearList()
    {
        questions.RemoveRange(0, questions.Count);
        chooseThemePanel.GetComponent<chooseThemeSrc>().isReset = true;   
    }

    public void Ckicking(ParticleSystem value)
    {
        value.Play();
    }
}


