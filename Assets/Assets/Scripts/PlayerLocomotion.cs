using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{

    InputManager inputManager;


    Vector3 moveDirection;
    Transform cameraObject;
    Rigidbody rgb;

    public float speed = 7;
    public float rotSpeed = 15 ;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        rgb = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
        Physics.gravity = new Vector3(0, -100.0F, 0);
    }
    private void HandleMovement()
    {
        moveDirection = cameraObject.forward * inputManager.verticalInput;
        moveDirection = moveDirection + cameraObject.right * inputManager.horisontalInput;
        moveDirection.Normalize();
        moveDirection.y = 0;
        moveDirection *= speed;

        Vector3 movementVelocity = moveDirection;
        rgb.velocity = movementVelocity;
    }

    private void Rotation()
    {
        Vector3 targetDirection = Vector3.zero;

        targetDirection = cameraObject.forward * inputManager.verticalInput;
        targetDirection += cameraObject.right * inputManager.horisontalInput;
        targetDirection.Normalize();
        targetDirection.y = 0;

        if (targetDirection == Vector3.zero)
            targetDirection = transform.forward;

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation , rotSpeed * Time.deltaTime);

        transform.rotation = playerRotation;
    }

    public void HandleAllMvt()
    {
        HandleMovement();
        Rotation();
    }
}
