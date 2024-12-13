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
    public int curQuicknessLV;
    [Range(1f, 20f)] public float maxMoveSpeed;
    [Range(1f, 20f)] public float curMoveSpeed;
    [Range(1f, 2f)] public float attackSpeed;

    //����
    [Header("����")]
    public int intellectualLV;
    [Range(500f, 5000f)] public float macMP; //ü�¿��� ����޴°� ������
    [Range(0f, 5000f)] public float curMP;
    [Range(50f, 500f)] public float M_attackPower;
    [Range(1f, 500f)] public float AdvancedManaManagement;//��޸������

    //�ٷ�
    [Header("�ٷ�")]
    public int muscularStrengthLV;
    public int curMuscularStrengthLV;
    [Range(50f, 500f)] public float p_attackPower;
    [Range(50f, 500f)] public float p_defense;

    //---------------------------- ���� ������ ��ü���� ��ġ�� �Ⱦ˷�������, �̰��̰Ű� �ö󰣴ٰ�� ǥ�����ֱ�

    //���� ģȭ��
    //[Header("���� ģȭ��")]
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
    //[Header("���� ���õ�")]

    //[Header("�˼�")]
    //���ݷ�
    //ġȮ
    //ġ��
    //���ݼӵ�

    //[Header("����")]
    //���ݷ�
    //ġȮ
    //ġ��
    //�����ӵ�
    //���� � �ɷ�

    //[Header("���ݼ�")]
    //���õ�

    //[Header("����")]
    //���õ�

    //[Header("�翪")]
    // Ÿ��(������) ���ҿ����� ������/ ����/ �������ķ� ����
    // ���ݷ�
    // ������
    // ����






}