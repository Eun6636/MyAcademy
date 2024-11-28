using UnityEngine;

public abstract class CharacterJob : ScriptableObject
{
    [SerializeField] protected SkillSO SkillData1;
    [SerializeField] protected SkillSO SkillData2;

    public GameObject SkillObject1;
    public GameObject SkillObject2;

    public abstract void Skill1(Vector2 position, Quaternion rotation);
    public abstract void Skill2(Vector2 position, Quaternion rotation);
}

[CreateAssetMenu(fileName = "NonWizade", menuName = "Jobs/NonWizade")] 
public class NonWizade : CharacterJob
{    

    public override void Skill1(Vector2 position, Quaternion rotation)
    {
        // 전직에 맞는 스킬 로직 구현
        // 예: 총알 생성 및 발사
    }

    public override void Skill2(Vector2 position, Quaternion rotation)
    {
        // 전직에 맞는 스킬 로직 구현
        // 예: 총알 생성 및 발사
    }
}

[CreateAssetMenu(fileName = "NonSword", menuName = "Jobs/NonSword")]
public class NonSword : CharacterJob
{


    public override void Skill1(Vector2 position, Quaternion rotation)
    {
        // 전직에 맞는 스킬 로직 구현
        // 예: 총알 생성 및 발사
    }

    public override void Skill2(Vector2 position, Quaternion rotation)
    {
        // 전직에 맞는 스킬 로직 구현
        // 예: 총알 생성 및 발사
    }
}
