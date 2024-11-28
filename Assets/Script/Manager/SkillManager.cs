using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public CharacterJob[] Job; // 각 전직의 배열



    public void UseSkill1(int index, Vector2 position, Quaternion rotation)
    {
        if (index < Job.Length)
        {
            Job[index].Skill1(position, rotation);
        }
    }

    public void UseSkill2(int index, Vector2 position, Quaternion rotation)
    {
        if (index < Job.Length)
        {
            Job[index].Skill2(position, rotation);
        }
    }
}