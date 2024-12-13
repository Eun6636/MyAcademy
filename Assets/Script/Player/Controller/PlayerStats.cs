using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum StatsChangeType  //얘는 뭐할때 쓰려는 거려나, 아직 모름
//{
//    Add,
//    Multiple,
//    Override,
//}

[Serializable]
public class PlayerStats
{
    //Pleasure Level 즐거움레벨
    //체력
    [Header("체력")]
    public int physicalStrengthLV;
    [Range(500, 3000)] public int maxHealth;
    [Range(0, 3000)] public int curHealth;

    //민첩
    [Header("민첩")]
    public int quicknessLV;
    public int curQuicknessLV;
    [Range(1f, 20f)] public float maxMoveSpeed;
    [Range(1f, 20f)] public float curMoveSpeed;
    [Range(1f, 2f)] public float attackSpeed;

    //지력
    [Header("지력")]
    public int intellectualLV;
    [Range(500f, 5000f)] public float macMP; //체력에도 영향받는게 좋을듯
    [Range(0f, 5000f)] public float curMP;
    [Range(50f, 500f)] public float M_attackPower;
    [Range(1f, 500f)] public float AdvancedManaManagement;//고급마나운용

    //근력
    [Header("근력")]
    public int muscularStrengthLV;
    public int curMuscularStrengthLV;
    [Range(50f, 500f)] public float p_attackPower;
    [Range(50f, 500f)] public float p_defense;

    //---------------------------- 저기 위에는 구체적인 수치는 안알려주지만, 이거이거가 올라간다고는 표시해주기

    //원소 친화도
    //[Header("원소 친화도")]
    //빛

    //어둠

    //불

    //물

    //바람

    //땅

    //복합 원소 능력치 (이건 원소 숙련도 옆에 +버튼 드레그하면 보이게 해야할듯)
    //번개(빛/불)

    //식물(빛/물/흙)

    //얼음(어둠/물/바람)

    //독(어둠/흙)

    //용암(불/흙)

    //폭풍(불/바람)



    //직업숙련도
    //[Header("직업 숙련도")]

    //[Header("검술")]
    //공격력
    //치확
    //치피
    //공격속도

    //[Header("마법")]
    //공격력
    //치확
    //치피
    //시전속도
    //동시 운영 능력

    //[Header("연금술")]
    //숙련도

    //[Header("장인")]
    //숙련도

    //[Header("사역")]
    // 타입(사용원소) 원소에따라 공격파/ 힐파/ 서포터파로 나뉨
    // 공격력
    // 버프량
    // 힐량






}