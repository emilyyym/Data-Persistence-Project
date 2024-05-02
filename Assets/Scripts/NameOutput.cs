using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NameOutput : MonoBehaviour
{
    public TextMeshProUGUI display_Player_name;

    public void Awake()
    {

        display_Player_name.text = NameInput.menu.Player_Name;
        DontDestroyOnLoad(display_Player_name);

    }
}
