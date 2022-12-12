using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectStage : MonoBehaviour
{
    public GameObject[] Enemy;
    [Header("Enemy �� �� �ִ� ���� ������ �ȴ�")]
    public int enemyNum;
    [Space(10f)]
    public AudioSource s_stageSel;

    public static bool Sel; // E_Test��ũ��Ʈ 26�ٿ��� ���̵Ǹ� ������ ü���� ���󺹱� ��Ŵ
    // Start is called before the first frame update

    void AllFalse()
    {
        for (int i = 0; i < enemyNum; i++)
        {
            Enemy[i].SetActive(false);
        }
        Sel = true;
        s_stageSel.Play();
    }
    public void Stage1_1()
    {
        AllFalse();
        Enemy[0].SetActive(true);
    }

    public void Stage1_2()
    {
        AllFalse();
        Enemy[1].SetActive(true);
    }

    public void Stage1_3()
    {
        AllFalse();
        Enemy[2].SetActive(true);
    }

    public void Stage1_4()
    {
        AllFalse();
        Enemy[3].SetActive(true);
    }

}
