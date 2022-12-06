using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Text : MonoBehaviour
{
    public TextMeshProUGUI t_money;
    public TextMeshProUGUI t_enemyHp;
    public TextMeshProUGUI t_lv;
    public TextMeshProUGUI t_lvex;
    [Header("�ɷ�ġ")]
    public TextMeshProUGUI t_abilityPoint;
    public TextMeshProUGUI t_abilAtk; 
    public TextMeshProUGUI t_abilCritDmg;
    public TextMeshProUGUI t_abilCritRate;
    //public TextMeshProUGUI t_damage;

    Color alpha;
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
        t_lvex.text = "EX  : " +Property.lvEx.ToString() + "/" + Property.necessityLvEx.ToString();
        t_abilityPoint.text = "���� �ɷ�ġ : " + Ability.abilityLv.ToString();
        t_abilAtk.text = "+" + Ability.atk.ToString();
        t_abilCritDmg.text = "+" + Ability.critDmg.ToString();
        t_abilCritRate.text = "+" + Ability.critRate.ToString();
        //t_damage.text = Property.attackPower.ToString();
        /*
        text 
        
         
         */
    }
}
