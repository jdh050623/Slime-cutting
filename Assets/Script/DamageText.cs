using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageText : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float alphaSpeed;
    [SerializeField] private float destroyTime;
    TextMeshPro damageText;
    public TextMeshPro distinctionText; //대미지 옆에 Hit!,Critical!!! 뜨는거
    Color alpha;
    Color alpha2;

    // Start is called before the first frame update
    void Start()
    {
        damageText = GetComponent<TextMeshPro>();
        alpha = damageText.color;
        alpha2 = distinctionText.color;
        
        Invoke("DestroyObject", destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        damageText.text = Property.attackPower.ToString();
        transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0)); // 텍스트 위치

        alpha.a = Mathf.Lerp(alpha.a, 0, Time.deltaTime * alphaSpeed);
        alpha2.a = Mathf.Lerp(alpha2.a, 0, Time.deltaTime * alphaSpeed);// 텍스트 알파값
        damageText.color = alpha;
        distinctionText.color = alpha2;
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
