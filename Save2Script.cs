using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save2Script : MonoBehaviour
{
    public GameObject oyako;
    public GameObject satooya;
    public GameObject Savescr;
    void Updata()
    {
        
    }
    public void OnClick()
    {
        SaveScript save = Savescr.GetComponent<SaveScript>();
        
        Debug.Log(save.field[0, 0, 0]);
        if (save.objName.Contains("Obj"))
        {
            Debug.Log(save.objName);
        }

    }
    public void keisyou()
    {
        
    }
}
