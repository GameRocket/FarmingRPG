using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour
{
    public enum LandStatus
    {
        Dry, Brown, Leaves
    }

    /// <summary>
    /// Mud material types
    /// dryMudMat - soilMat (Dry)
    /// brownMudMat - farmlandMat (Brown)
    /// leavesMudMat - wateredMat (Leaves)
    /// </summary>
    public Material dryMudMat, brownMudMat, leavesMudMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
