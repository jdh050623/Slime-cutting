using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour
{
    public GameObject[] Enemy;
    public AudioSource s_stageSel;
    public static bool Sel;
    // Start is called before the first frame update
    public void Stage1_1()
    {
        Enemy[0].SetActive(true);
        Enemy[1].SetActive(false);
        Sel = true;
        s_stageSel.Play();
    }

    public void Stage1_2()
    {
        Enemy[1].SetActive(true);
        Enemy[0].SetActive(false);
        Sel = true;
        s_stageSel.Play();
    }

}
