using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerInput : MonoBehaviour
{
    public InputField playerInput1;
    public string playerName;

    public void NameSet()
    {
        playerName = playerInput1.text;
        Debug.Log(playerName);
    }

    public void StartGame()
    {
        PlayerPrefs.SetString("ThisPlayer", playerName);
        SceneManager.LoadScene("Main");
    }

}
