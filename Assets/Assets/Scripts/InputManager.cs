using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playercontrols;
    AnimatorManager animatorManager;

    public float verticalInput;
    public float horisontalInput;

    public Vector2 movementInput;
    public float moveAmoun;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
    }

    private void OnEnable()
    {
        if(playercontrols == null)
        {
            playercontrols = new PlayerControls();

            playercontrols.Playermvt.Movements.performed += i => movementInput = i.ReadValue<Vector2>();
        }

        playercontrols.Enable();
    }

    private void OnDisable()
    {
        playercontrols.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horisontalInput = movementInput.x;
        moveAmoun = Mathf.Clamp01(Mathf.Abs(horisontalInput) + Mathf.Abs(verticalInput));
        animatorManager.UpdateAnimatorValues(0, moveAmoun);
    }
}
