using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFalse : MonoBehaviour //캔버스에 있는 AbilityBg, StageBg 같은 캔버스에 있는 모든 Bg가 켜져있을때 Enemy들을 잠시 꺼둔게 해줌 
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
