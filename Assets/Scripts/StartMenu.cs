using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public static StartMenu instance;

    public InputField userName;

    public int highScore;
    public string usersName;
    // Start is called before the first frame update
    void awake()
    {
        userName = GetComponent<InputField>();

        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        
    }

    public void startGame()
    {

        instance = this;
        usersName = userName.text;
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
