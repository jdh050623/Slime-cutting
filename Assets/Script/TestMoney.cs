using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestMoney : MonoBehaviour
{
    public TextMeshProUGUI t_money;
    public TextMeshProUGUI t_enemyHp;
    public TextMeshProUGUI t_lv;
    public TextMeshProUGUI t_lvex;
    [Header("�ɷ�ġ")]
    public TextMeshProUGUI t_abilityPoint;
    public TextMeshProUGUI t_atk; 
    public TextMeshProUGUI t_critDmg;
    public TextMeshProUGUI t_critRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t_money.text = "�� : " + Property.money.ToString();
        t_enemyHp.text = "������ ü�� : " + E_Test.hp.ToString();
        /*t_lv.text = "�� : " + Property.attackPower.ToString();*/
        t_lv.text = "LV : " + Property.lv.ToString();
        t_lvex.text = "EX  : " + Property.necessityLvEx.ToString() + "/" + Property.lvEx.ToString();
        t_abilityPoint.text = "���� �ɷ�ġ : " + Ability.abilityLv.ToString();
        t_atk.text = "+" + Ability.atk.ToString();
        t_critDmg.text = "+" + Ability.critDmg.ToString();
        t_critRate.text = "+" + Ability.critRate.ToString();
    }
}
