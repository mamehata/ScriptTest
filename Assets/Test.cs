using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // moneyを200で初期化する
        int money = 50;

        if(money >= 100)
        {
            // moneyの値が100以上の場合、文字列を表示する
            Debug.Log("ポーションを買う");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
