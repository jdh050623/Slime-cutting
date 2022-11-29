using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject setting;
    public GameObject ability;

    public void abilityOn()
    {
        ability.SetActive(true);
    }

    public void abilityOff()
    {
        ability.SetActive(false);
    }
}
