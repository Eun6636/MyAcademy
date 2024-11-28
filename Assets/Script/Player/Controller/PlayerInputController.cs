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
        Debug.Log("�����̽ÿ�");
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
        // Vector ���� �Ǽ��� ��ȯ
        {
            CallLookEvent(newAim);
        }
    }

    public void OnSkill1(InputValue value)  //���������� ���⼭ �˻�
    {
        Debug.Log("Skill1" + value.ToString()); 
        IsAttacking = value.isPressed;
    }

    public void OnSkill2(InputValue value)  //���������� ���⼭ �˻�
    {
        Debug.Log("Skill2" + value.ToString()); 
        IsAttacking = value.isPressed;
    }
}