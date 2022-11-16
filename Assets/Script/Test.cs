using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    public GameObject attack;
    private void Start()
    {

    }
    private void Update()
    {
        Vector3 m_ps = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        this.transform.position = Camera.main.ScreenToWorldPoint(m_ps);


        if (Input.GetMouseButton(0))
        {
  
        }
    }

}
