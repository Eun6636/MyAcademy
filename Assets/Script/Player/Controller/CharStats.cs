using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum StatsChangeType  //얘는 뭐할때 쓰려는 거려나, 아직 모름
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