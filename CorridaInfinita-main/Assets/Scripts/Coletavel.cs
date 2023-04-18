using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int value = 10;
    public GameObject explosionPrefap;
    private BoxCollider2D bc;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("deu certo");

       bc = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
       bc.isTrigger = true;



        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            if (GameManager.gm != null)
            {
                GameManager.gm.Collect(value);
            }
            if (explosionPrefap != null)
            {
                Instantiate(explosionPrefap, transform.position, Quaternion.identity);
            }
            
        }
    }

    // Update is called once per frame

}
