using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject Ölme, BölümGeçme;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Engel")
        {
            Ölme.SetActive(true);
            Time.timeScale = 0f;           
        }

        if (collision.gameObject.tag == "Son")
        {
            BölümGeçme.SetActive(true);
            Time.timeScale = 0f;           
        }
    }
}
