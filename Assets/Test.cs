using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // money‚ğ50‚Å‰Šú‰»‚·‚é
        int money = 50;

        if(money >= 100)
        {
            // money‚ª100ˆÈã‚¾‚Á‚½ê‡
            Debug.Log("ƒ|[ƒVƒ‡ƒ“‚ğ”ƒ‚¤");
        }
        else
        {
            // money‚ª100–¢–‚¾‚Á‚½ê‡
            Debug.Log("•Ší‚ğ”„‚é");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
