using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    //public GameObject setting;
    public GameObject ability;
    public GameObject stageBg;

    public AudioSource s_bt;

    public void abilityOn()
    {
        ability.SetActive(true);
        s_bt.Play();
    }

    public void abilityOff()
    {
        ability.SetActive(false);
        s_bt.Play();
    }

    public void stageBgOn()
    {
        stageBg.SetActive(true);
        s_bt.Play();
    }

    public void stageBgOff()
    {
        stageBg.SetActive(false);
        s_bt.Play();
    }
}
