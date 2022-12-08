using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandle : MonoBehaviour
{
    private PlayerInput playerInput;
    public Vector2 input_Movement;
    public Vector2 input_view;
    public bool jumped; 
    CharacterController characterController;
    private float speed = 11f;



    public void Awake()
    {
        characterController = GetComponent<CharacterController>();
        playerInput = new PlayerInput();
        playerInput.Mouse.MouseDelta.performed += e => input_view = e.ReadValue<Vector2>();
        playerInput.Movement.MovementPlayer.performed += e => input_Movement = e.ReadValue<Vector2>();
        playerInput.Movement.Jump.started += e => jumped = true;
        playerInput.Movement.Jump.canceled += e => jumped = false;
        playerInput.Enable();
        Debug.Log(input_Movement);
        

    }
    public void FixedUpdate()
    {   
    //    characterController.Move(new Vector3(input_Movement.x, 0 , input_Movement.y )*speed * Time.deltaTime);
        Debug.Log(jumped);
       // Jumped();
    }
   // void Jumped()
   // {
   //     if(jumped)
     //   {
       //     characterController.Move(new Vector3( 0 , 11f, 0 ) * Time.deltaTime);
       // }
      //  else
       // {
          //  characterController.Move(new Vector3( 0 , -9.8f, 0 ) * Time.deltaTime);

       // }
   // }


    
}
