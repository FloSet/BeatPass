using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour {

    public Text noFurtherLevel;

    //Wird ausgelöst wenn jemand den Zieltrigger berührt
    private void OnTriggerEnter2D(Collider2D collision)
    {
        List<string> scenesInBuild = new List<string>();

        //Durchloopt alle im Build enthaltenen Ziele
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            //Ermittlung des Pfades der Scene
            string scenePath = SceneUtility.GetScenePathByBuildIndex(i);
            //Pfad abschneiden und nur Dateiname übrig lassen
            int lastSlash = scenePath.LastIndexOf("/");
            //Entfernung von Dateiendungen und hinzufügen zur Liste
            scenesInBuild.Add(scenePath.Substring(lastSlash + 1, scenePath.LastIndexOf(".") - lastSlash - 1));
        }

        int currentSceneNumber;

        try
        {
            //Ermittlung der Levelnummer
            currentSceneNumber = Int32.Parse(SceneManager.GetActiveScene().name.ToString().Substring(5));
        }
        catch (Exception e)
        {
            //Im Fall eines Fehlers bei Level 1 anfangen
            //TODO: Bessere Lösung, z. B. Fehlermeldung dafür evtl. noFurtherLevel Feld in allgemeines Statusfeld umwandeln
            currentSceneNumber = 1;
            Debug.Log("Fehler in der Levelbennung!\n" + e);
        }

        //Level mit nächst höhere Nummer laden oder "Keine weiteren Levels" ausgeben
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
