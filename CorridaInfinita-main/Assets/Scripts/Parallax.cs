using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [Range(0f, 1f)] public float parallaxSpeed = 0f;
    public Transform cameraTransform;
    private float Xant;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GameObject.Find("Main Camera").GetComponent<Camera>().transform;
        Xant = cameraTransform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaCamera = cameraTransform.position.x - Xant;
        Vector3 newPos = transform.position;
        newPos.x += parallaxSpeed * deltaCamera;
        transform.position = newPos;
        Xant = cameraTransform.position.x;
    }
}
