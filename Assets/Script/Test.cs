using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    [SerializeField] private GameObject attack;
    [SerializeField] private GameObject atPos;
    [SerializeField] private GameObject atCol;
    public static bool atOn;
    private void Update()
    {
        Vector3 m_ps = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        atPos.transform.position = Camera.main.ScreenToWorldPoint(m_ps);
        if (Input.GetMouseButton(0))
        {
            atCol.SetActive(true);
            attack.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            atCol.SetActive(false);
            attack.SetActive(false);
        }

        if (attack.activeSelf == true)
        {
            atOn = true;
        }
        else
        {
            atOn = false;
        }
    }

}
