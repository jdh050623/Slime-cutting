using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotUsed : MonoBehaviour //������� ���� �����̳� ���� ���� ������ ���� ���� ������ ��ư�� ���������� �˷���
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
