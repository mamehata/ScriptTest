using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // moneyを205で初期化する
        int money = 205;
        if (money <= 50)
        {
            // moneyが50以下だった場合の処理
            Debug.Log("武器を売る");
        }
        else if (money >= 200)
        {
            // moneyが200以上だった場合の処理
            Debug.Log("武器を買う");
        }
        else
        {
            // それ以外の場合の処理
            Debug.Log("ポーションを買う");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
