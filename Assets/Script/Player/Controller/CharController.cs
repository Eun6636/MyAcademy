using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    //public event Action<AttackSO> OnAttackEvent;

    private float _timeSinceLastAttack = float.MaxValue;
    protected bool IsAttacking { get; set; } //트루가 되면

    //protected CharacterStatsHandler Stats { get; private set; }

    protected virtual void Awake()
    {
        //Stats = GetComponent<CharacterStatsHandler>();
    }

    protected virtual void Update()
    {
        HandleAttackDelay();
    }


    private void HandleAttackDelay()
    {

    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    //public void CallAttackEvent(AttackSO attackSO)
    //{
    //    OnAttackEvent?.Invoke(attackSO);
    //}
}
