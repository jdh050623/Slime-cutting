using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomDel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Del());
    }
    IEnumerator Del()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
}
