using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour
{
    public Text NameBox;
    public InputField textbox;
    
    // Start is called before the first frame update
    void Start()
    {
        NameBox.text = PlayerPrefs.GetString("name");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickSaveButton()
    {
        PlayerPrefs.SetString("name", textbox.text);
        
    }
}
