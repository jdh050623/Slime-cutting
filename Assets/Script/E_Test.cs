using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Test : MonoBehaviour
{
    public GameObject HitEffect;
    public GameObject BOOM;
    public GameObject DmgText; // 때렸을때 나오는 데미지
    public GameObject CriDmgText;//때렸을때 나오는 크리데미지
    //public Transform TextSpon; // 때렸을때 나오는 텍스트의 위치
    private bool hitDelay;
    public static float maxHp;
    public float maxHp1;
    public int dropLvEx;
    public int myNum;

    [SerializeField] public static float hp; //실제 몬스터 hp
    SpriteRenderer sr;

    private void Start()
    {
        hp = maxHp1;
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        maxHp = maxHp1;
        if (SelectStage.Sel == true)
        {
            hp = maxHp1;
            SelectStage.Sel = false;
        }
        
        Death();
    }
    void OnMouseEnter()
    {
        if(Test.atOn == true)
        {
            Hit();
        }
    }

    private void Hit()
    {
        if(!hitDelay)
        {
            hitDelay = true;
            Property.money = Property.money + Property.moneyUp;
            bool crit = Property.CriChance(Ability.critRate); // 크리티컬 확률
            if (crit)
            {
                hp = hp - Property.criDmg;
                Instantiate(CriDmgText, /*TextSpon*/transform.position, Quaternion.Euler(0, 0, 0));
                Debug.Log("크리 뜸" + Property.criDmg);

            }
            else
            {
                hp = hp - Property.attackPower;
                Instantiate(DmgText, /*TextSpon*/transform.position, Quaternion.Euler(0, 0, 0));
                Debug.Log("크리 안뜸");
            }

            transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
            sr.material.color = new Color(1, 0.5f, 0.5f);
            HitEffect.SetActive(true);
            StartCoroutine(SizeColl());
        }
    }

    private void Death()
    {
        if (hp <= 0)
        {
            Instantiate(BOOM, transform.position, transform.rotation);
            HitEffect.SetActive(false);
            sr.material.color = new Color(1, 1, 1);
            hp = maxHp;
            Property.lvEx = Property.lvEx + dropLvEx;
            gameObject.transform.position = new Vector3(0, 3, 0);
        }
    }

    IEnumerator SizeColl()
    {
        yield return new WaitForSeconds(0.2f);
        transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        sr.material.color = new Color(1, 1, 1);
        HitEffect.SetActive(false);
        hitDelay = false;
    }


}


