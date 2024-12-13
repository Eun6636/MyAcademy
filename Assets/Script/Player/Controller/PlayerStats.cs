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
public class PlayerStats
{
    //Pleasure Level ��ſ򷹺�
    //ü��
    [Header("ü��")]
    public int physicalStrengthLV;
    [Range(500, 3000)] public int maxHealth;
    [Range(0, 3000)] public int curHealth;

    //��ø
    [Header("��ø")]
    public int quicknessLV;
    [Range(1f, 20f)] public float maxMoveSpeed;
    [Range(1f, 20f)] public float curMoveSpeed;
    [Range(1f, 2f)] public float attackSpeed;

    //����
    [Header("����")]
    public int intellectualLV;
    [Range(50f, 500f)] public float M_attackPower;
    [Range(1f, 500f)] public float AdvancedManaManagement;//��޸������

    //�ٷ�
    [Header("�ٷ�")]
    public int muscularStrengthLV;
    [Range(50f, 500f)] public float p_attackPower;
    [Range(50f, 500f)] public float p_defense;

    //���� ģȭ��
    [Header("���� ģȭ��")]
    //��

    //���

    //��

    //��

    //�ٶ�

    //��

    //���� ���� �ɷ�ġ (�̰� ���� ���õ� ���� +��ư �巹���ϸ� ���̰� �ؾ��ҵ�)
    //����(��/��)

    //�Ĺ�(��/��/��)

    //����(���/��/�ٶ�)

    //��(���/��)

    //���(��/��)

    //��ǳ(��/�ٶ�)



    //�������õ�
    //�˼�

    //����

    //���ݼ�

    //����

    //�翪




}