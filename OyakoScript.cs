using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyakoScript : MonoBehaviour
{
    [SerializeField] private GameObject parentObject;
    GameObject KoObject;

    // Use this for initialization
    private void Start()
    {
        // 子オブジェクトを全て取得する
        foreach (Transform childTransform in parentObject.transform)
        {
            Debug.Log(childTransform.gameObject.name);
            KoObject = childTransform.gameObject;
            KoObject.SetActive(true);
            Debug.Log(KoObject);
        }
    }
}
