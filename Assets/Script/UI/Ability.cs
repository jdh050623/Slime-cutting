using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ability : BtSound
{
    public static float abilityLv; //���� �ɷ�ġ
    public static float critRate; // ġ��Ÿ Ȯ�� ����
    public static float critDmg; // ġ��Ÿ ������ ����
    public static float atk; // ���ݷ� ����
    public AudioSource s_powerUp;
    public AudioSource s_powerAllUp;

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
            s_powerUp.Play();
            abilityLv--;
            atk++;
        }   
    }

    public void AllAtkUp()
    {
        if (abilityLv >= 1) s_powerAllUp.Play();
        atk = atk + abilityLv;
        abilityLv = 0;    
    }

    public void CritRateUp() //ġȮ
    {
        if (abilityLv >= 1)
        {
            s_powerUp.Play();
            abilityLv--;
            critRate++;
        }
    }

    public void AllCritRateUp()
    {
        if (abilityLv >= 1) s_powerAllUp.Play();
        critRate = critRate + abilityLv;
        abilityLv = 0;   
    }

    public void CritDmgUp() //ġ��
    {
        if (abilityLv >= 1)
        {
            s_powerUp.Play();
            abilityLv--;
            critDmg++;
        }
    }

    public void AllCritDmgUp()
    {
        if (abilityLv >= 1) s_powerAllUp.Play();
        critDmg = critDmg + abilityLv;
        abilityLv = 0;
    }
}
