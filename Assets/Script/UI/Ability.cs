using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ability : MonoBehaviour
{
    public static float abilityLv; //���� �ɷ�ġ
    public static float critRate; // ġ��Ÿ Ȯ�� ����
    public static float critDmg; // ġ��Ÿ ������ ����
    public static float atk; // ���ݷ� ����

    [Header("�׽�Ʈ ��")]
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
        /*//�׽�Ʈ��~
        critRate = criRate;
        critDmg = criDmg;
        //~�׽�Ʈ��*/

        Property.attackPower = 1 + (4 * atk); //���� ���ݷ�
    }
    //���� �� ��ư ������ ��
    public void AtkUp() //���ݷ�
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

    public void CritRateUp() //ġȮ
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

    public void CritDmgUp() //ġ��
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
