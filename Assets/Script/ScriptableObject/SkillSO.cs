using UnityEngine;
using static UnityEngine.Tilemaps.Tile;

[CreateAssetMenu(fileName = "NewSkill", menuName = "Skills/New Skill")]
public class SkillSO : ScriptableObject
{
    public string skillName;
    public GameObject skillObject;
    public Sprite skillSprite;
    public Collider2D sKillCollider;
    public float baseDamage;
    public float cooldown; //쿨타임
    public float duration; //지속시간
}
