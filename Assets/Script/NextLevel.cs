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
        List<string> scenesInBuild = new List<string>();
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            string scenePath = SceneUtility.GetScenePathByBuildIndex(i);
            int lastSlash = scenePath.LastIndexOf("/");
            scenesInBuild.Add(scenePath.Substring(lastSlash + 1, scenePath.LastIndexOf(".") - lastSlash - 1));
        }


        foreach (String s in scenesInBuild)
        {
            Debug.Log(s);
        }

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

        if (scenesInBuild.Contains("Level" + (currentSceneNumber + 1)))
        {
            SceneManager.LoadScene("Level" + (currentSceneNumber + 1));
        }
        else
        {
            noFurtherLevel.enabled = true;
        }
    }
}
