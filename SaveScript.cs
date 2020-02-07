using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScript : MonoBehaviour
{
    public int su = 0;
    public string moji;
    public int[,,] field = new int[70, 10, 40];
    public GameObject[,,] objField = new GameObject[10,10,10];
    public GameObject cube;
    public string objName;
    
    // Start is called before the first frame update
    void Start()
    {
        su = 20;
        moji = "あああ";
        field[0, 0, 0] = 2;
        objField[0, 0, 0] = cube;
        objName = objField[0, 0, 0].name;
        
    }
}
