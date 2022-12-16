using System.Collections;
using System.Collections.Generic;
using static System.Math;
using UnityEngine;

public class Property : MonoBehaviour
{
    public static float money;
    public static float moneyUp = 1;
    public static float attackPower = 1;
    public static float criDmg;//실제 크리 데미지

    public GameObject t_LvUp;

    public static float lv = 1;
    public static float lvEx;
    [SerializeField] private float necessityLvEx1;
    public static float necessityLvEx;

    public AudioSource lvUp;

    private void Start()
    {
        necessityLvEx = necessityLvEx1;
    }

    private void Update()
    {
        criDmg = 1.5f*(attackPower + (attackPower * 2f * (0.08f * Ability.critDmg)));
        criDmg = Mathf.Round(criDmg);

        if (Input.GetKeyDown(KeyCode.A))
        {
            lvEx = lvEx+50;
        }

        /*if (Input.GetKeyDown(KeyCode.D))
        {
            bool crit = CriChance(100); // 크리티컬 확률
            if (crit)
            {
                Debug.Log("크리 뜸");
            }

            else
            {
                Debug.Log("크리 안뜸");
            }
        }*/

        if (lvEx >= necessityLvEx) //레벨업 시스템
        {
            Ability.abilityLv++;
            lvEx = lvEx - necessityLvEx;
            lv++;
            t_LvUp.SetActive(true);
            lvUp.Play();
            StartCoroutine(T_LvDel());
            necessityLvEx = necessityLvEx * 1.5f;
            Mathf.Ceil(necessityLvEx);
            
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

    IEnumerator T_LvDel()
    {
        yield return new WaitForSeconds(0.9f);
        t_LvUp.SetActive(false);
    }

}
