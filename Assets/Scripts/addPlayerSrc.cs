﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addPlayerSrc : MonoBehaviour
{
    
    [SerializeField]
    private GameObject namePrefabBtn;
    private Text textprefab;

    [SerializeField]
    private GameObject gridlayer;

    [SerializeField]
    private InputField addTable;

    private Text _namePlayer;
    //private int count = 0;
    public Text namePlayer
    {
        get 
        {
            AddNewPlayer();
            return _namePlayer;    
        }
        set 
        {
            _namePlayer = value;
           
        }
    }
    

    public void Start()
    {
        textprefab = namePrefabBtn.transform.Find("namePlayer").gameObject.GetComponent<Text>();

        
    }

    public void Update()
    {
        

    }

    void AddNewPlayer()
    {
        
        GameObject ui = GameObject.Find("UIManager");
        textprefab.text = _namePlayer.text;
        var table = Instantiate(namePrefabBtn);
        if (_namePlayer.text != "" & gridlayer.transform.childCount < 6)
        {
            if (ui.GetComponent<UIManager>().namePlayer.Count != 0)
            {
                int count = 0;
#pragma warning disable CS0162 // Обнаружен недостижимый код
                for (int i = 0; i < ui.GetComponent<UIManager>().namePlayer.Count; i++)
#pragma warning restore CS0162 // Обнаружен недостижимый код
                {
                    if (ui.GetComponent<UIManager>().namePlayer[i] == _namePlayer.text)
                    {
                        count += 1;
                    }
                }
                if (count > 0)
                {
                    addTable.text = "";
                    return;
                }
                else
                {
                    table.transform.SetParent(gridlayer.transform, false);
                    ui.GetComponent<UIManager>().SetValueStruct(textprefab.text);
                    addTable.text = "";
                    return;
                }
            }
            else
            {
                table.transform.SetParent(gridlayer.transform, false);
                ui.GetComponent<UIManager>().SetValueStruct(textprefab.text);
                addTable.text = "";
            }
            
        }
    }
   
    public void DestroyObj(GameObject objDeleted)
    {
        Text textNamePrefab = objDeleted.transform.Find("namePlayer").gameObject.GetComponent<Text>();

        GameObject ui = GameObject.Find("UIManager");
        ui.GetComponent<UIManager>().DeleteName(textNamePrefab.text);
        Destroy(objDeleted);

    }
    
}
