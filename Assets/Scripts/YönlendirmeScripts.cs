using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YönlendirmeScripts : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void CikisButonu()
    {
        Application.Quit();
    }

    public void KayitEkrani()       // Sahne Arası Geçiş
    {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene("KayitEkrani");
    }

    //public void OpenPanel()         // Panel Açma Kapama
    //{

    //    if (Panel != null)
    //    {
    //        Panel.SetActive(true);
    //    }
    //}
}
