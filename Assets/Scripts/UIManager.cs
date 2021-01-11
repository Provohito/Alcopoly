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
    private Image fillground;
    private string _nameUI;
    public string nameUI
    {
        get {return _nameUI;}
        set { _nameUI = value;}
    }
    [HideInInspector]
    public string simpleVariable;
    //блок выбора темы
    [HideInInspector]
    public List<string> questions = new List<string>();
    string path = @"D:\Work\Alcopoly\Assets\Resources\";
    string nameTheme;

    List<string> firstListLoad = new List<string>();
    [SerializeField]
    public Text firstLoadText;
    

    public void Start()
    {
        LoadFirstText();
        

    }

    void Update()
    {
        if (Input.GetKeyDown("d"))
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
        Debug.Log(simpleVariable + " Прошлая");
        Debug.Log(name + " настоящая");
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
    
    private void LoadFirstText()
    {
        
        using (StreamReader sr = new StreamReader(@"D:\Work\Alcopoly\Assets\Resources\advice.txt", System.Text.Encoding.Default))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                firstListLoad.Add(line);
                Debug.Log(line);

            }
        }
        firstLoadText.text = firstListLoad[UnityEngine.Random.Range(0, firstListLoad.Count)];
    }

    public void WriteText(string value)
    {
        nameTheme = value;
        using (StreamReader sr = new StreamReader(path + value + ".txt", System.Text.Encoding.Default))
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

    public void wqe()
    {
        for (int i = 0; i < namePlayer.Count; i++)
        {
            Debug.Log(namePlayer[i]);
        }
    }   
    public void ClearList()
    {
        for (int i = 0; i < questions.Count; i++)
        {
            questions.RemoveAt(i);
        }
    }
}


