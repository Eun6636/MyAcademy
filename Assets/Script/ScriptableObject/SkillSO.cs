using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Tilemaps.Tile;

public enum ElementType //���� Ÿ��
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
    public float Amount; //����/��/����
    public bool isAoE;  //���������� üũ, �����谡 �ƴϸ� ���Ͱ� �¾����� �����
    public float cooldown; //��Ÿ��
    public float duration; //���ӽð�
    public List<ISkillEffect> effects;
}
