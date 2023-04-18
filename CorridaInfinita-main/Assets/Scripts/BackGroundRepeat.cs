using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRepeat : MonoBehaviour


{

    public float offset = 19f;
    public Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position.x + offset) < cameraTransform.position.x)
        {
            Vector3 newPos = transform.position;
            newPos.x += 2 * offset;
            transform.position = newPos;
        }
    }
}
