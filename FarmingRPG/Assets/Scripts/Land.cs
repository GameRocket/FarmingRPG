using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour
{
    public enum LandStatus
    {
        Dry, Brown, Leaves
    }

    public LandStatus landStatus;

    /// <summary>
    /// Mud material types
    /// dryMudMat - soilMat (Dry)
    /// brownMudMat - farmlandMat (Brown)
    /// leavesMudMat - wateredMat (Leaves)
    /// </summary>
    public Material dryMudMat, brownMudMat, leavesMudMat;
    new Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        //  Get the renderer component
        renderer = GetComponent<Renderer>();

        //  Set the land to dry by default
        SwitchLandStatus(LandStatus.Dry);
    }

    /// <summary>
    ///  Method to handle a land status
    /// </summary>
    /// <param name="statusToSwitch"></param>
    public void SwitchLandStatus(LandStatus statusToSwitch)
    {
        landStatus = statusToSwitch;

        Material materialToSwitch = dryMudMat ;

        // Decide what material to switch to and reflect the changes on our cube
        switch(statusToSwitch)
        {
            case LandStatus.Dry:
                //  Switch to the dry material
                materialToSwitch = dryMudMat;
                break;
            case LandStatus.Brown:
                //  Switch to the brown material
                materialToSwitch = brownMudMat;
                break;
            case LandStatus.Leaves:
                //  Switch to the leaves material
                materialToSwitch = leavesMudMat;
                break;
        }

        //  Get the renderer to apply the changes
        renderer.material = materialToSwitch;
    }
}
