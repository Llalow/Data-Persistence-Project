using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuUiManager : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject nameSpace;

    public void Storename()
    {
        theName = inputField.GetComponent<Text>().text;
        nameSpace.GetComponent<Text>().text = "welcome " + theName;

        PlayerNamePersist.Instance.playerName = theName;
    }

    private void Update()
    {
        

    }

    
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        
        
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit(); // original code to quit Unity player
        #endif
    }
}
