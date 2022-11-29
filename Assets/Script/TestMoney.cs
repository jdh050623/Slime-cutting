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
    [Header("능력치")]
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
        t_money.text = "돈 : " + Property.money.ToString();
        t_enemyHp.text = "슬라임 체력 : " + E_Test.hp.ToString();
        /*t_lv.text = "공 : " + Property.attackPower.ToString();*/
        t_lv.text = "LV : " + Property.lv.ToString();
        t_lvex.text = "EX  : " + Property.necessityLvEx.ToString() + "/" + Property.lvEx.ToString();
        t_abilityPoint.text = "남은 능력치 : " + Ability.abilityLv.ToString();
        t_atk.text = "+" + Ability.atk.ToString();
        t_critDmg.text = "+" + Ability.critDmg.ToString();
        t_critRate.text = "+" + Ability.critRate.ToString();
    }
}
