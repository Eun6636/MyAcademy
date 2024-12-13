using UnityEngine;

public class SkillManager : MonoBehaviour
{
    private static SkillManager _instance;



    public static SkillManager Instance
    {

        //�̱���
        get
        {
            if (_instance == null)
            {
                // ���� SkillManager�� ������ ���� ����
                GameObject obj = new GameObject("SkillManager");
                _instance = obj.AddComponent<SkillManager>();
            }

            return _instance;
        }

    }

    [Header("���� ����")]
    public CharacterJob Job; // �� ������ �迭

    private void Awake()
    {
        // �ٸ� SkillManager�� �����ϸ� �ı�
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(gameObject); // �� ��ȯ �� �ı����� �ʵ���
    }

    public void UseSkill1(int index, Vector2 position, Quaternion rotation)
    {
        Job.Skill1(position, rotation);
    }

    public void UseSkill2(int index, Vector2 position, Quaternion rotation)
    {
        Job.Skill2(position, rotation);
    }
}
