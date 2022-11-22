using System.Collections;
using System.Collections.Generic;
using static System.Math;
using UnityEngine;

public class Property : MonoBehaviour
{
    public static float money;
    public static float moneyUp = 1;
    public static float attackPower = 1;
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            lvEx = lvEx+50;
            Debug.Log(moneyUp);
        }

        if(lvEx >= necessityLvEx)
        {
            lvEx = lvEx - necessityLvEx;
            lv++;
            necessityLvEx = necessityLvEx * 1.5f;
            Mathf.Ceil(necessityLvEx);  //Truncate(necessityLvEx * 10)/10;
        }
        necessityLvEx = Mathf.Round(necessityLvEx);
    }
}
