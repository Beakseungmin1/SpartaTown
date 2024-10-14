using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera _camera;

    protected override void Awake()
    {
        base.Awake();
        _camera = Camera.main; // mainCamera태그붙어있는 카메라를 가져온다.
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveinput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveinput);
        // 실제 움직이는 처리는 여기서하는게 아니라 PlaterMovement에서 함
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.WorldToScreenPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }

    //public void OnFire(InputValue value)
    //{
    //    isAttacking = value.isPressed;
    //    Debug.Log(isAttacking);
    //}



}
