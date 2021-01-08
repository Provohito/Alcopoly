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
        Debug.Log(_namePlayer.text);
        GameObject ui = GameObject.Find("UIManager");
        textprefab.text = _namePlayer.text;
        var table = Instantiate(namePrefabBtn);
        if (_namePlayer.text != "" & gridlayer.transform.childCount < 6)
        {
            if (ui.GetComponent<UIManager>().namePlayer.Count != 0)
            {
                for (int i = 0; i < ui.GetComponent<UIManager>().namePlayer.Count; i++)
                {
                    if (ui.GetComponent<UIManager>().namePlayer[i] == _namePlayer.text)
                    {
                        return;
                    }
                    else
                    {
                        table.transform.SetParent(gridlayer.transform, false);
                        ui.GetComponent<UIManager>().SetValueStruct(textprefab.text);
                    }
                }
            }
            else
            {
                table.transform.SetParent(gridlayer.transform, false);
                ui.GetComponent<UIManager>().SetValueStruct(textprefab.text);
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
