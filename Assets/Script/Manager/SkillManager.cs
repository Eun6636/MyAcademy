using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public CharacterJob[] skills; // �� ������ ��ų �迭



    public void UseSkill1(int index, Vector2 position, Quaternion rotation)
    {
        if (index < skills.Length)
        {
            skills[index].Skill1(position, rotation);
        }
    }

    public void UseSkill2(int index, Vector2 position, Quaternion rotation)
    {
        if (index < skills.Length)
        {
            skills[index].Skill1(position, rotation);
        }
    }
}