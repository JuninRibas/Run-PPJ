using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroier : MonoBehaviour
{
    public Canvas GameOver;
    public Canvas Placar;

    private void Start()
    {
        GameOver.gameObject.SetActive(false);
        Placar.gameObject.SetActive(true);
    }



    void OnTriggerEnter2D(Collider2D outro)
    {
        if(outro.gameObject.tag == "MainCam"){

        }   else {

        if (outro.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            GameOver.gameObject.SetActive(true);
            Placar.gameObject.SetActive(false);
            // Debug.Break();
            return;
        }

        else
        {
            if (outro.gameObject.transform.parent)
            {
                Destroy(outro.gameObject.transform.parent.gameObject);
            }
            else
            {
                Destroy(outro.gameObject);
            }
        }
        }
    }
}
