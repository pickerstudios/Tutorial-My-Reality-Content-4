using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLook : MonoBehaviour
{
    public Transform  player, cameraTrans;
  
    void LateUpdate()
    {
        cameraTrans.LookAt (player);
    }
}
