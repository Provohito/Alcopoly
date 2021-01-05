using System.Collections;
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

    private Text _namePlayer;
    //private int count = 0;
    public Text namePlayer
    {
        get 
        {
            AddNewPlayer();
            return namePlayer;    
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
            var table = Instantiate(namePrefabBtn);
            table.transform.SetParent(gridlayer.transform,false); 
        }
    }
}
