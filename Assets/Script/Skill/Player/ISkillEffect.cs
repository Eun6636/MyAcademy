using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �������̽�

public abstract class ISkillEffect : ScriptableObject
{
    public abstract void ApplyEffect(SkillSO skillSO, GameObject target);
}

// ������ ȿ��
[CreateAssetMenu(fileName = "DamageEffect", menuName = "Skill Effects/Damage Effect")]
public class DamageEffect : ISkillEffect
{

    public override void ApplyEffect(SkillSO skillSO, GameObject target)
    {
        //var health = target.GetComponent<HealthComponent>();
        //if (health != null)
        //{
        //    // ���� �� ���
        //    float multiplier = ElementAffinity.GetAffinityMultiplier(elementType, health.elementType);
        //    health.TakeDamage(damageAmount * multiplier);
        //}
    }
}

// ���� ȿ�� (�÷��̾� �浹 ������, ���� ������ ��� ������, ��� ��� ���� ������ �ҵ�
[CreateAssetMenu(fileName = "BuffEffect", menuName = "Skill Effects/Buff Effect")]
public class BuffEffect : ISkillEffect
{
    public BuffEffectType buffType;

    public override void ApplyEffect(SkillSO skillSO, GameObject target)
    {
        //var buffManager = target.GetComponent<BuffManager>();
        //if (buffManager != null)
        //{
        //    buffManager.ApplyBuff(buffType, buffAmount, buffDuration);
        //}
    }
}

// ����� ȿ��
[CreateAssetMenu(fileName = "DebuffEffect", menuName = "Skill Effects/Debuff Effect")]
public class DebuffEffect : ISkillEffect
{
    public DeBuffEffectType debuffType;

    public override void ApplyEffect(SkillSO skillSO, GameObject target)
    {
        //var debuffManager = target.GetComponent<DebuffManager>();
        //if (debuffManager != null)
        //{
        //    debuffManager.ApplyDebuff(debuffType, debuffIntensity, debuffDuration);
        //}
    }
}

//ġ��Ÿ ����/��ø/ �ٷ�/ 
public enum BuffEffectType
{
    Heal,     //��
    Agility,  //��ø��������
    Strength, //�ٷ·�������
    CRD       //ũ������������

}

public enum DeBuffEffectType
{
    Slow,   //���ο�
    Stun,   //����
    DotDamage //��Ʈ ������
}