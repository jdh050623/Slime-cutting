using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ability : MonoBehaviour
{
    public static float abilityLv; //남은 능력치
    public static float critRate; // 치명타 확률 스탯
    public static float critDmg; // 치명타 데미지 스탯
    public static float atk; // 공격력 스탯

    [Header("테스트 용")]
    public float criDmg; 
    public float criRate;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            abilityLv++;
            Debug.Log(abilityLv);
        }
        /*//테스트용~
        critRate = criRate;
        critDmg = criDmg;
        //~테스트용*/

        Property.attackPower = 1 + (4 * atk); //스탯 공격력
    }
    //스탯 업 버튼 눌렀을 때
    public void AtkUp() //공격력
    {
        if(abilityLv >= 1)
        {
            abilityLv--;
            atk++;
        }   
    }

    public void AllAtkUp()
    {
        atk = atk + abilityLv;
        abilityLv = 0;
    }

    public void CritRateUp() //치확
    {
        if (abilityLv >= 1)
        {
            abilityLv--;
            critRate++;
        }
    }

    public void AllCritRateUp()
    {
        critRate = critRate + abilityLv;
        abilityLv = 0;
    }

    public void CritDmgUp() //치뎀
    {
        if (abilityLv >= 1)
        {
            abilityLv--;
            critDmg++;
        }
    }

    public void AllCritDmgUp()
    {
        critDmg = critDmg + abilityLv;
        abilityLv = 0;
    }
}
