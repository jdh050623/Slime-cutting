using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFalse : MonoBehaviour //ĵ������ �ִ� AbilityBg, StageBg ���� ĵ������ �ִ� ��� Bg�� ���������� Enemy���� ��� ���а� ���� 
{
    /*public GameObject AbilityBg;
    public GameObject StageBg;*/
    public GameObject EnemyGroup;
    public GameObject[] Bg;
    public int BgNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(AbilityBg.activeSelf == true)
        {
            EnemyGroup.SetActive(false);
        }

        if (AbilityBg.activeSelf == true)
        {
            EnemyGroup.SetActive(false);
        }*/


        for (int i = 0; i < BgNum; i++)
        {
            if(Bg[i].activeSelf == true)
            {
                EnemyGroup.SetActive(false);
            }
        }

        if (Bg[0].activeSelf == false && Bg[1].activeSelf == false)
        {
            EnemyGroup.SetActive(true);
        }
    }
}
