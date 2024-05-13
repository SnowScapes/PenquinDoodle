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
        Vector2 screenPos = value.Get<Vector2>(); // Input System에서 받아 온 마우스 포인터의 화면 좌표
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos); // mainCamera 기준의 화면 좌표를 World 좌표로 변환
        Vector2 relativePos = (worldPos - (Vector2)transform.position).normalized; // 캐릭터를 기준으로 현재 마우스 포인터의 상대 좌표
        CallLookEvent(relativePos);
    }
}