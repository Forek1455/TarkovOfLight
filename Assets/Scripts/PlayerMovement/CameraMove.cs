using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{   
    InputHandle inputHandle;
    Transform playerBody;
    public Transform playerObject;
    float xRotation = 0f;
    
     private void Start() {
    Cursor.lockState = CursorLockMode.Locked;    
    }
    
     private void FixedUpdate() 
    {
        Vector3 player = playerObject.position;
        Vector3 camera = transform.position;  
        transform.position = Vector3.Lerp(camera , player, 10005f * Time.deltaTime);
    //ddaadadwasd    cameraMove();
    }
    ///private void cameraMove()
  //  {
        //float mouseX = inputHandle.input_view.x * 100f * Time.deltaTime;
       // float mouseY = inputHandle.input_view.y * 100f * Time.deltaTime;

       // xRotation -= mouseY;
       // xRotation = Mathf.Clamp(xRotation, -90f , 90f);

       // transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
       // playerBody.Rotate(Vector3.up * mouseX);
    //}



}

    

   

