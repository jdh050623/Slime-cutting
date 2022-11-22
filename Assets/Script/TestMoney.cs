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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t_money.text = "M : " + Property.money.ToString();
        t_enemyHp.text = "Enemy HP : " + E_Test.hp.ToString();
        t_lv.text = "LV : " + Property.lv.ToString();
        t_lvex.text = "EX  : " + Property.necessityLvEx.ToString() + "/" + Property.lvEx.ToString();
    }
}
