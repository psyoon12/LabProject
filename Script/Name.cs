using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Name : MonoBehaviour
{
    public static string playerNameString;
    public Text playerName;

    public bool alreadyNamed;

    void Start()
    {
        if (alreadyNamed = true) 
        {
            playerName.text = playerNameString;
        }
        
    }

    public void SaveName(string newName)
    {
        alreadyNamed = true;
        PlayerPrefs.SetString("name", newName);
    }
}
