using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    /// <summary>
    /// Reference to a player controller class
    /// </summary>
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        //  Get access to our PlayerController component
        playerController = transform.parent.parent.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //  This will be our hit info (whatever raycast hits)
        RaycastHit hit;

        //  Checking if our player interacts with something
        if(Physics.Raycast(transform.position, Vector3.down, out hit, 1))
        {
            OnInteractableHit(hit);
        }    
    }

    /// <summary>
    /// Method called when the player hit something that he can interact with
    /// </summary>
    void OnInteractableHit(RaycastHit hit)
    {
        Collider other = hit.collider;
        
        //  Showing message
        Debug.Log(other.tag);
    }
}
