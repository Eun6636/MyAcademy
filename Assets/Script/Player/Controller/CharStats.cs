using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum StatsChangeType  //��� ���Ҷ� ������ �ŷ���, ���� ��
//{
//    Add,
//    Multiple,
//    Override,
//}

[Serializable]
public class CharStats
{
    [Range(1, 100)] public int maxHealth;
    [Range(1, 100)] public int Health;

    [Range(1f, 20f)] public float Speed;
    //public AttackSO attackSO;
}