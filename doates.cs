using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doates : MonoBehaviour
{

    public GameObject Toire;

    private RaycastHit hit;
    string ClickObjName; // クリックしたオブジェクトの名前
    GameObject ClickObj; // クリックしたしたオブジェクト
    int su = 0;
    Vector3 pos = new Vector3(0, 0, 0);
    List<GameObject> myList = new List<GameObject>();
    GameObject[] Hairetu;
    bool han = true;


    // クリックしたオブジェクトの2マス下と3マス下を非表示にして
    // 3マス目があった場所にオブジェクトを配置するコード
    // ・判定方法の追加案
    // クリックしたオブジェクト名に"wall"の名が付いていたら入る
    // 最初にクリックしたマスの名前を"masuDoa"などに変更して
    // "wall"の判定に入らないようにする（ドアを配置した場所を選択できないようにする）
    // ・現状の問題点
    // クリックしている間にオブジェクトの非表示、配置、再表示をしているので
    // クリックしているX座標Y座標が処理途中にずれた場合や処理が終わる前に
    // クリックをやめてしまうとバグが出る
    // 
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (su < 3)
                {
                    // クリックしたオブジェクトの名前を取得
                    ClickObjName = hit.collider.gameObject.name;
                    // stringからGameObjectに
                    ClickObj = GameObject.Find(ClickObjName);
                    // クリックしたオブジェクトの座標を取得
                    pos = ClickObj.transform.position;
                    if (su == 0)
                    {
                        myList.Add(ClickObj);
                    }
                    // オブジェクトを非表示に
                    ClickObj.SetActive(false);
                    su++;
                }
                else if (han == true)
                {
                    han = false;
                    Instantiate(Toire).transform.position = new Vector3(pos.x, pos.y, pos.z);
                    myList[0].SetActive(true);
                }
            }
            
        }
        
    }
}
