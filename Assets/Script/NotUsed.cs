using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotUsed : MonoBehaviour //사용하지 않은 스탯이나 새로 얻은 아이템 같은 것이 있을때 버튼에 빨간점으로 알려줌
{
    public GameObject AbilityNew;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AbilityPoint();
    }

    void AbilityPoint()
    {
        if (Ability.abilityLv != 0)
        {
            AbilityNew.SetActive(true);
        }
        else
        {
            AbilityNew.SetActive(false);
        }
    }
}
