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
            //범위계인지 확인해서 사라질지 유지할지 고민
            

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
