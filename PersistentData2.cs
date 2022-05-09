using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PersistentData2 : MonoBehaviour
{
    //[SerializeField] string playerName = "";
    //[SerializeField] int playerScore;
    public static PersistentData2 Instance;
    [SerializeField] string playerNameText;
    //public InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        //playerName = PlayerPrefs.GetString("name");
        //DisplayName();
        //playerName = "";
        
        //PlayerPrefs.SetString("name", playerName);
        playerNameText = PlayerPrefs.GetString("name");

        //PlayerPrefs.SetString("name", playerName);
        //PlayerPrefs.SetString("name", playerName);
        //DisplayName();
        //playerNameText = PlayerPrefs.GetInt("name");
        // playerScore = 0;
    }

    // void Awake()
    // {
    //     if(Instance == null)
    //     {
    //         DontDestroyOnLoad(this);
    //         Instance = this;
    //     }
    //     else
    //         Destroy(gameObject);
    // }

    // public void SetName(string name)
    // {
    //     playerName = name;
    //     //PlayerPrefs.SetString("name", playerName);
    // }

    // // public void SetScore(int score)
    // // {
    // //     playerScore = score;
    // // }

    // public string GetName()
    // {
    //     return playerName;
    // //     //playerName.text = "Score: " + playerName;
    // //     //playerNameText = PlayerPrefs.SetInt("name", playerName);
    // }

    // public int GetScore()
    // {
    //     return playerScore;
    // }
    // Update is called once per frame
    public void DisplayName()
    {
        playerNameText = "Name: " + playerNameText;
        PlayerPrefs.SetString("name", playerNameText);
        //playerNameText = PlayerPrefs.SetString("name", playerName);
    }

    void Update()
    {
        
        PlayerPrefs.SetString("name", playerNameText);
        DisplayName();
                
    }

    // public void reset()
    // {
    //     int level = SceneManager.GetActiveScene().buildIndex;
    //     if(level > 4)
    //     {
    //         playerName = "";
    //         PlayerPrefs.SetString("name", playerName);
    //     }
    // }
}