using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject �lme, B�l�mGe�me;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Engel")
        {
            �lme.SetActive(true);
            Time.timeScale = 0f;           
        }

        if (collision.gameObject.tag == "Son")
        {
            B�l�mGe�me.SetActive(true);
            Time.timeScale = 0f;           
        }
    }
}
