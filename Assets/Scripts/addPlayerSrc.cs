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

    

    List<string> playerName = new List<string>();

    
    
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

        if (_namePlayer.text != "" & gridlayer.transform.childCount < 6)
        {
            textprefab.text = _namePlayer.text;
            playerName.Add(textprefab.text);
            var table = Instantiate(namePrefabBtn);
            table.transform.SetParent(gridlayer.transform,false); 
        }
    }
   
    public void DestroyObj(GameObject objDeleted)
    {
        
        // Через PlayerPreffs
        
        
        Text textNamePrefab = objDeleted.transform.Find("namePlayer").gameObject.GetComponent<Text>();
        
        for (int i = 0; i < playerName.Count; i++)
        {
            Debug.Log(textNamePrefab.text + "wer");
            Debug.Log(playerName[i] + "tyu");
            if (textNamePrefab.text == playerName[i])
            {
                Debug.Log("win");
                playerName.RemoveAt(i);
                
            }
        }
        Destroy(objDeleted);

    }
    
}
