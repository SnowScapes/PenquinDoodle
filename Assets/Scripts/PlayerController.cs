using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : InputController
{
    public void OnMove(InputValue value)
    {
        //Debug.Log(value.Get<Vector2>().magnitude);
        Vector2 moveInput = value.Get<Vector2>().normalized;
        Debug.Log(moveInput.magnitude);
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
        CallLookEvent(value.Get<Vector2>());
    }
}