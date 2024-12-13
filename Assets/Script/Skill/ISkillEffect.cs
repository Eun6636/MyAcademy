using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �������̽�
public interface ISkillEffect
{
    void ApplyEffect(GameObject target);
}

// ������ ȿ��
[System.Serializable]
public class DamageEffect : ISkillEffect
{
    public float damageAmount;
    public ElementType elementType;

    public void ApplyEffect(GameObject target)
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

// ���� ȿ��
[System.Serializable]
public class BuffEffect : ISkillEffect
{
    //public BuffType buffType;
    public float buffDuration;
    public float buffAmount;

    public void ApplyEffect(GameObject target)
    {
        //var buffManager = target.GetComponent<BuffManager>();
        //if (buffManager != null)
        //{
        //    buffManager.ApplyBuff(buffType, buffAmount, buffDuration);
        //}
    }
}

// ����� ȿ��
[System.Serializable]
public class DebuffEffect : ISkillEffect
{
    //public DebuffType debuffType;
    public float debuffDuration;
    public float debuffIntensity;

    public void ApplyEffect(GameObject target)
    {
        //var debuffManager = target.GetComponent<DebuffManager>();
        //if (debuffManager != null)
        //{
        //    debuffManager.ApplyDebuff(debuffType, debuffIntensity, debuffDuration);
        //}
    }
}