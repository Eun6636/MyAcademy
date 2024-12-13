using UnityEngine;

public class SkillManager : MonoBehaviour
{
    private static SkillManager _instance;



    public static SkillManager Instance
    {

        //싱글톤
        get
        {
            if (_instance == null)
            {
                // 씬에 SkillManager가 없으면 새로 생성
                GameObject obj = new GameObject("SkillManager");
                _instance = obj.AddComponent<SkillManager>();
            }

            return _instance;
        }

    }

    [Header("세팅 직업")]
    public CharacterJob Job; // 각 전직의 배열

    private void Awake()
    {
        // 다른 SkillManager가 존재하면 파괴
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(gameObject); // 씬 전환 시 파괴되지 않도록
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
