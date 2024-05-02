using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class NameInput : MonoBehaviour
{
    public static NameInput Scene1;
    public TMP_InputField inputField;

    public string Player_Name;

    private void Awake()
    {
        if(Scene1 == null)
        {
            Scene1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SetPlayerName()
    {
        Player_Name = inputField.text;

        SceneManager.LoadSceneAsync("Scene2");
    }

}
