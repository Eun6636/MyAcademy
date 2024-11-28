using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CharStatsHandler : MonoBehaviour
{
    private PlayerStats baseStats; //base 
    public PlayerStats CurrentStats;
    
    //public List<CharStats> statsModifiers = new List<CharStats>();  //나중에 아이템 먹고 추가할 스테이터스 생기면 이걸 씀


    //private const float MinSpeed = 0.8f;
    //private const int MinMaxHealth = 5;

    //private void Awake()
    //{
    //    UpdateCharacterStats();
    //}

    //public void AddStatModifier(CharStats statModifier)
    //{
    //    statsModifiers.Add(statModifier);
    //    UpdateCharacterStats();
    //}

    //public void RemoveStatModifier(CharStats statModifier)
    //{
    //    statsModifiers.Remove(statModifier);
    //    UpdateCharacterStats();
    //}

    //private void UpdateCharacterStats()  //얘는 무슨 기능 하는거냐? 
    //{
    //    AttackSO attackSO = null;
    //    if (baseStats.attackSO != null)
    //    {
    //        attackSO = Instantiate(baseStats.attackSO);
    //    }

    //    CurrentStats = new CharStats { attackSO = attackSO };
    //    // TODO
    //    CurrentStats.statsChangeType = baseStats.statsChangeType;
    //    CurrentStats.maxHealth = baseStats.maxHealth;
    //    CurrentStats.speed = baseStats.speed;
    //    UpdateStats((a, b) => b, baseStats);
    //    if (CurrentStats.attackSO != null)
    //    {
    //        CurrentStats.attackSO.target = baseStats.attackSO.target;
    //    }


    //    //두개의 값중 하나를 하겟다?
    //    foreach (CharStats modifier in statsModifiers.OrderBy(o => o.statsChangeType))
    //    {
    //        if (modifier.statsChangeType == StatsChangeType.Override)
    //        {
    //            UpdateStats((o, o1) => o1, modifier);
    //        }
    //        else if (modifier.statsChangeType == StatsChangeType.Add)
    //        {
    //            UpdateStats((o, o1) => o + o1, modifier);
    //        }
    //        else if (modifier.statsChangeType == StatsChangeType.Multiple)
    //        {
    //            UpdateStats((o, o1) => o * o1, modifier);
    //        }
    //    }

    //    LimitAllStats();
    //}


    ////원래 스테이터스에서 추가
    //private void UpdateStats(Func<float, float, float> operation, CharStats newModifier)
    //{
    //    CurrentStats.maxHealth = (int)operation(CurrentStats.maxHealth, newModifier.maxHealth);
    //    CurrentStats.speed = operation(CurrentStats.speed, newModifier.speed);

    //    if (CurrentStats.attackSO == null || newModifier.attackSO == null)
    //        return;

    //    UpdateAttackStats(operation, CurrentStats.attackSO, newModifier.attackSO);


    //    //타입이 다르다면 처리 X
    //    if (CurrentStats.attackSO.GetType() != newModifier.attackSO.GetType())
    //    {
    //        return;
    //    }

    //    switch (CurrentStats.attackSO)
    //    {
    //        case RangedAttackData _:
    //            ApplyRangedStats(operation, newModifier);
    //            break;
    //    }
    //}

    //private void UpdateAttackStats(Func<float, float, float> operation, AttackSO currentAttack, AttackSO newAttack)
    //{
    //    if (currentAttack == null || newAttack == null)
    //    {
    //        return;
    //    }

    //    currentAttack.delay = operation(currentAttack.delay, newAttack.delay);
    //    currentAttack.power = operation(currentAttack.power, newAttack.power);
    //    currentAttack.size = operation(currentAttack.size, newAttack.size);
    //    currentAttack.speed = operation(currentAttack.speed, newAttack.speed);
    //}

    //private void ApplyRangedStats(Func<float, float, float> operation, CharStats newModifier)
    //{
    //    RangedAttackData currentRangedAttacks = (RangedAttackData)CurrentStats.attackSO;

    //    if (!(newModifier.attackSO is RangedAttackData))
    //    {
    //        return;
    //    }

    //    RangedAttackData rangedAttacksModifier = (RangedAttackData)newModifier.attackSO;
    //    currentRangedAttacks.multipleProjectilesAngel =
    //        operation(currentRangedAttacks.multipleProjectilesAngel, rangedAttacksModifier.multipleProjectilesAngel);
    //    currentRangedAttacks.spread = operation(currentRangedAttacks.spread, rangedAttacksModifier.spread);
    //    currentRangedAttacks.duration = operation(currentRangedAttacks.duration, rangedAttacksModifier.duration);
    //    currentRangedAttacks.numberofProjectilesPerShot = Mathf.CeilToInt(operation(currentRangedAttacks.numberofProjectilesPerShot,
    //        rangedAttacksModifier.numberofProjectilesPerShot));
    //    currentRangedAttacks.projectileColor = UpdateColor(operation, currentRangedAttacks.projectileColor, rangedAttacksModifier.projectileColor);
    //}

    //private Color UpdateColor(Func<float, float, float> operation, Color currentColor, Color newColor)
    //{
    //    return new Color(
    //        operation(currentColor.r, newColor.r),
    //        operation(currentColor.g, newColor.g),
    //        operation(currentColor.b, newColor.b),
    //        operation(currentColor.a, newColor.a));
    //}

    //private void LimitStats(ref float stat, float minVal)
    //{
    //    stat = Mathf.Max(stat, minVal);
    //}

    //private void LimitAllStats()
    //{
    //    if (CurrentStats == null || CurrentStats.attackSO == null)
    //    {
    //        return;
    //    }

    //    LimitStats(ref CurrentStats.attackSO.delay, MinAttackDelay);
    //    LimitStats(ref CurrentStats.attackSO.power, MinAttackPower);
    //    LimitStats(ref CurrentStats.attackSO.size, MinAttackSize);
    //    LimitStats(ref CurrentStats.attackSO.speed, MinAttackSpeed);
    //    LimitStats(ref CurrentStats.speed, MinSpeed);
    //    CurrentStats.maxHealth = Mathf.Max(CurrentStats.maxHealth, MinMaxHealth);
    //}
}
