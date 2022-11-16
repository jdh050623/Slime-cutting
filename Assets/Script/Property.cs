using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{
    public static float money;
    public static float moneyUp = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            moneyUp = moneyUp + 1;
            Debug.Log(moneyUp);
        }
    }
}
