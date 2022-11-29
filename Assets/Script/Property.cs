using System.Collections;
using System.Collections.Generic;
using static System.Math;
using UnityEngine;

public class Property : MonoBehaviour
{
    public static float money;
    public static float moneyUp = 1;
    public static float attackPower = 1;
    public static float criDmg;//角力 农府 单固瘤

    public static float lv = 1;
    public static float lvEx;
    [SerializeField] private float necessityLvEx1;
    public static float necessityLvEx;

    private void Start()
    {
        necessityLvEx = necessityLvEx1;
    }

    private void Update()
    {
        criDmg = attackPower + (attackPower * (0.08f * Ability.critDmg));
        criDmg = Mathf.Round(criDmg);

        if (Input.GetKeyDown(KeyCode.A))
        {
            lvEx = lvEx+50;
            Debug.Log(moneyUp);
        }

        /*if (Input.GetKeyDown(KeyCode.D))
        {
            bool crit = CriChance(100); // 农府萍拿 犬伏
            if (crit)
            {
                Debug.Log("农府 朵");
            }

            else
            {
                Debug.Log("农府 救朵");
            }
        }*/

        if (lvEx >= necessityLvEx)
        {
            Ability.abilityLv++;
            lvEx = lvEx - necessityLvEx;
            lv++;
            necessityLvEx = necessityLvEx * 1.5f;
            Mathf.Ceil(necessityLvEx);  //Truncate(necessityLvEx * 10)/10;
        }
        necessityLvEx = Mathf.Round(necessityLvEx);
    }

    /*public static bool GetThisChanceResult(float Chance)
    {
        if (Chance < 0.0000001f)
        {
            Chance = 0.0000001f;
        }

        bool Success = false;
        int RandAccuracy = 10000000;
        float RandHitRange = Chance * RandAccuracy;
        int Rand = UnityEngine.Random.Range(1, RandAccuracy + 1);
        if (Rand <= RandHitRange)
        {
            Success = true;
        }
        return Success;
    }*/

    public static bool CriChance(float Percentage_Chance)
    {
        if (Percentage_Chance < 0.0000001f)
        {
            Percentage_Chance = 0.0000001f;
        }

        Percentage_Chance = Percentage_Chance / 100;

        bool Success = false;
        int RandAccuracy = 10000000;
        float RandHitRange = Percentage_Chance * RandAccuracy;
        int Rand = UnityEngine.Random.Range(1, RandAccuracy + 1);
        if (Rand <= RandHitRange)
        {
            Success = true;
        }
        return Success;
    }


    
}
