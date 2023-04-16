using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //  Player transform component
    Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        //  Find the player game object in the scene and gets its transform component
        playerPos = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
