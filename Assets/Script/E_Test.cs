using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Test : MonoBehaviour
{
    void OnMouseEnter()
    {
       
        Property.money = Property.money + Property.moneyUp;
    }

}
