using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    public void RotateCameraRight()
    {
        transform.Rotate(Vector3.up, 15, Space.Self);
    }


    public void RotateCameraLeft()
    {
        transform.Rotate(Vector3.up, -15, Space.Self);
    }


}
