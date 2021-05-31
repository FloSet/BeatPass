using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour {

    public Text noFurtherLevel;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        int currentSceneNumber;

        try
        {
            currentSceneNumber = Int32.Parse(currentSceneName.Substring(5));
        }
		catch (Exception e)
        {
            currentSceneNumber = 1;
            Debug.Log("Fehler in der Levelbennung!\n" + e);
        }

        if(SceneManager.GetSceneByName("Level" + (currentSceneNumber + 1)).IsValid())
        {
            Debug.Log(currentSceneNumber);
            SceneManager.LoadScene("Level" + (currentSceneNumber + 1));
            Debug.Log("Nächstes Level: " + (currentSceneNumber + 1));
        }
        else{
            noFurtherLevel.enabled = true;
        }
    }
}
