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
    public GameObject Sayfa1;
    public GameObject Sayfa2;
    public GameObject Sayfa3;
    public GameObject HikayeBalonu1, HikayeBalonu2, HikayeBalonu3, HikayeBalonu4;
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
        HikayeMenusu.SetActive(false);
        Sayfa1.SetActive(false);
        Sayfa2.SetActive(false);
        Sayfa3.SetActive(false);
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
        BackGroundImage1.SetActive(false );
        HikayeMenusu.SetActive(true);
        Sayfa1.SetActive(true);
     
    }
    
    public void HikayeAtla()
    {
        if(Sayfa1.active==true)
        {
            Sayfa1.SetActive(false);
            Sayfa2.SetActive(true);
        }
        else if(Sayfa2.active==true)
        {
            Sayfa2.SetActive(false);
            Sayfa3.SetActive(true);
        }
    }
    
    public void HikayeBalonu()
    {
        if(HikayeBalonu1== null && HikayeBalonu2==null && HikayeBalonu3==null && HikayeBalonu4==null)
        {
            HikayeBalonu1.SetActive(true);
        }
        else if (HikayeBalonu1.active==true && HikayeBalonu2 == null && HikayeBalonu3 == null && HikayeBalonu4 == null)
        {
            HikayeBalonu1.SetActive(false);
            HikayeBalonu2.SetActive(true);
        }
        else if (HikayeBalonu1==null && HikayeBalonu2.active==true && HikayeBalonu3 == null && HikayeBalonu4 == null)
        {
            HikayeBalonu2.SetActive(false);
            HikayeBalonu3.SetActive(true);
        }
        else if (HikayeBalonu1 == null && HikayeBalonu2==null && HikayeBalonu3.active==true && HikayeBalonu4 == null)
        {
            HikayeBalonu3.SetActive (false);
            HikayeBalonu4.SetActive(true);
        }
        else if (HikayeBalonu1 == null && HikayeBalonu2 == null && HikayeBalonu3==null && HikayeBalonu4.active==true)
        {
            HikayeBalonu4.SetActive (false);
            SceneManager.LoadScene(1);
        }
    }
    
}
