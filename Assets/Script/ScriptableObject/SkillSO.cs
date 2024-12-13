using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Tilemaps.Tile;

public enum ElementType //원소 타입
{
    Non,

    Light,
    Dark,
    Fire,
    Water,
    Wind,
    Land,

    Lightning,
    Plant,
    Ice,
    Lava,
    Storm,
    Poison

}


[CreateAssetMenu(fileName = "NewSkill", menuName = "Skills/New Skill")]
public class SkillSO : ScriptableObject
{
    public string skillName;
    public GameObject skillObject;
    public Sprite skillSprite;
    public Collider2D sKillCollider;
    [Header("data")]
    public ElementType elementTyp;
    public float Amount; //버프/힐/딜량
    public bool isAoE;  //범위계인지 체크, 범위계가 아니면 몬스터가 맞았을때 사라짐
    public float cooldown; //쿨타임
    public float duration; //지속시간
    public List<ISkillEffect> effects;
}
