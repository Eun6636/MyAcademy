using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 공통 인터페이스
public interface ISkillEffect
{
    void ApplyEffect(GameObject target);
}

// 데미지 효과
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
        //    // 원소 상성 계산
        //    float multiplier = ElementAffinity.GetAffinityMultiplier(elementType, health.elementType);
        //    health.TakeDamage(damageAmount * multiplier);
        //}
    }
}

// 버프 효과
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

// 디버프 효과
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