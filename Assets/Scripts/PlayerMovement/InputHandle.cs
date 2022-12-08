using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandle : MonoBehaviour
{
    private PlayerInput playerInput;
    public Vector2 input_Movement;
    public Vector2 input_view;
    CharacterController characterController;
    private float speed = 1f;
    Transform camera;



    public void Awake()
    {
        characterController = GetComponent<CharacterController>();
        playerInput = new PlayerInput();
        playerInput.Mouse.MouseDelta.performed += e => input_view = e.ReadValue<Vector2>();
        playerInput.Movement.MovementPlayer.performed += e => input_Movement = e.ReadValue<Vector2>();

        playerInput.Enable();
        Debug.Log(input_Movement);

    }
    public void FixedUpdate()
    {
        characterController.Move(new Vector3(input_Movement.x, 0 , input_Movement.y )*speed);
    }
    private void CameraMoving()
    {

    }

    
}
