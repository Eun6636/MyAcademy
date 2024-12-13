using UnityEngine;

public abstract class CharacterJob : ScriptableObject
{
    [SerializeField] protected SkillSO SkillData1;
    [SerializeField] protected SkillSO SkillData2;

    //���⼭�� ��ų�� �������� ��� �������� �ٸ������� ó��
    public abstract void Skill1(Vector2 position, Quaternion rotation);
    public abstract void Skill2(Vector2 position, Quaternion rotation);
}

[CreateAssetMenu(fileName = "NonWizade", menuName = "Jobs/NonWizade")] 
public class NonWizade : CharacterJob
{    

    public override void Skill1(Vector2 position, Quaternion rotation)
    {
        // �÷��̾� �ִϸ��̼�
        // ������ �´� ��ų ���� ����
        // ��: �Ѿ� ���� �� �߻�
    }

    public override void Skill2(Vector2 position, Quaternion rotation)
    {
        // ������ �´� ��ų ���� ����
        // ��: �Ѿ� ���� �� �߻�
    }
}

[CreateAssetMenu(fileName = "NonWizade(fire)", menuName = "Jobs/NonWizade(fire)")]
public class NonWizade_fire : CharacterJob
{

    public override void Skill1(Vector2 position, Quaternion rotation)
    {
        // ������ �´� ��ų ���� ����
        // ��: �Ѿ� ���� �� �߻�
    }

    public override void Skill2(Vector2 position, Quaternion rotation)
    {
        // ������ �´� ��ų ���� ����
        // ��: �Ѿ� ���� �� �߻�
    }
}



[CreateAssetMenu(fileName = "NonSword", menuName = "Jobs/NonSword")]
public class NonSword : CharacterJob
{


    public override void Skill1(Vector2 position, Quaternion rotation)
    {
        // ������ �´� ��ų ���� ����
        // ��: �Ѿ� ���� �� �߻�
    }

    public override void Skill2(Vector2 position, Quaternion rotation)
    {
        // ������ �´� ��ų ���� ����
        // ��: �Ѿ� ���� �� �߻�
    }
}
