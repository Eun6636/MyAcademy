using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillCollider : MonoBehaviour
{
    public SkillSO skillSO;

    private void Start()
    {
        Invoke("OnDestroy", skillSO.duration);
    }


    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("enemy"))
        {
            //���������� Ȯ���ؼ� ������� �������� ���
            

            foreach (var effect in skillSO.effects)
            {
                effect.ApplyEffect(skillSO, other.gameObject);
            }

        }
    }

    private void OnDestroy()
    {
        Destroy(gameObject);
    }
}
