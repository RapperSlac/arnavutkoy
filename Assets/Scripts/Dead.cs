using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Engel")
        {
            Time.timeScale = 0f;
        }

        if (collision.gameObject.tag == "Son")
        {
            Time.timeScale = 0f;
        }
    }
}
