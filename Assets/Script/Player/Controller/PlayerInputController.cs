using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharController
{
    private Camera _camera;
    protected override void Awake()
    {
        base.Awake();
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Debug.Log("움직이시오");
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        // Vector 값을 실수로 변환
        {
            CallLookEvent(newAim);
        }
    }

    public void OnSkill1(InputValue value)  //실질적으로 여기서 검사
    {
        Debug.Log("Skill1" + value.ToString()); 
        IsAttacking = value.isPressed;
    }

    public void OnSkill2(InputValue value)  //실질적으로 여기서 검사
    {
        Debug.Log("Skill2" + value.ToString()); 
        IsAttacking = value.isPressed;
    }
}