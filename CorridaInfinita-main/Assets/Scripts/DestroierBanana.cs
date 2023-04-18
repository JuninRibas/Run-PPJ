using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroierBanana : MonoBehaviour
{




    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            // Debug.Break();
            return;
        }

    }
}
