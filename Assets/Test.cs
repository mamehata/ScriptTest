using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // sum‚ğ0‚Å‰Šú‰»‚·‚é
        int sum = 0;
        // 10‰ñˆ—‚ğŒJ‚è•Ô‚·
        for (int i = 1; i <= 10; i++)
        {
            // i‚Ì’l‚ğsum‚É‘«‚·
            sum += i;
        }
        // sum‚Ì’l‚ğ•\¦‚·‚é
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
