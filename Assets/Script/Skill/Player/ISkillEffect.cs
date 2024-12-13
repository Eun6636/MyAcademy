using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 공통 인터페이스

public abstract class ISkillEffect : ScriptableObject
{
    public abstract void ApplyEffect(SkillSO skillSO, GameObject target);
}

// 데미지 효과
[CreateAssetMenu(fileName = "DamageEffect", menuName = "Skill Effects/Damage Effect")]
public class DamageEffect : ISkillEffect
{

    public override void ApplyEffect(SkillSO skillSO, GameObject target)
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

// 버프 효과 (플레이어 충돌 버프랑, 몬스터 때릴때 얻는 버프랑, 상시 사용 버프 나눠야 할듯
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

// 디버프 효과
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

//치명타 피해/민첩/ 근력/ 
public enum BuffEffectType
{
    Heal,     //힐
    Agility,  //민첩레벨증가
    Strength, //근력레벨증가
    CRD       //크리데미지증가

}

public enum DeBuffEffectType
{
    Slow,   //슬로우
    Stun,   //스턴
    DotDamage //도트 데미지
}