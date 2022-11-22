using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Test : MonoBehaviour
{
    public GameObject HitEffect;
    public GameObject BOOM;
    private bool hitDelay;
    public float maxHp;
    public int dropLvEx;
    [SerializeField] public static float hp;
    SpriteRenderer sr;

    private void Start()
    {
        hp = maxHp;
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
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
            hp = hp - Property.attackPower;
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


