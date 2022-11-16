using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestMoney : MonoBehaviour
{
    public TextMeshProUGUI t_money;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t_money.text = "M : " + Property.money.ToString();
    }
}
