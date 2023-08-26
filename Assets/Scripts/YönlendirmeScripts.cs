using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YönlendirmeScripts : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject BackGroundImage1;
    public GameObject MagazaImage;
    public GameObject SesiAc;
    public GameObject SesiKapat;
    public GameObject HikayeMenusu;
    public void CikisButonu()
    {
        Application.Quit();
    }

    public void OynaButonu()       // Sahne Arası Geçiş
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("KayitEkrani");
    }

    public void OpenMagaza()
    {
             
        MagazaImage.SetActive(true);
        BackGroundImage1.SetActive(false);        
    }

    public void AnaMenu()
    {
        HikayeMenusu.SetActive(false);
        MagazaImage.SetActive(false);
        BackGroundImage1.SetActive(true);
    }
    
    public void SesAc()
    {   
        SesiAc.SetActive(true);
        SesiKapat.SetActive(false);
    }
    
    public void SesKapat()
    {
        SesiAc.SetActive(false);
        SesiKapat.SetActive(true);
    }

    public void HikayeMenuAc()
    {
        HikayeMenusu.SetActive(true);
    }
    
    
}
