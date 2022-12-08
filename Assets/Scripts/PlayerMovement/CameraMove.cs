using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerObject;
    
    
     private void FixedUpdate() 
    {
        Vector3 player = playerObject.position;
        Vector3 camera = transform.position;  
        transform.position = Vector3.Lerp(camera , player, 10005f * Time.deltaTime);
    }



}

    

   

