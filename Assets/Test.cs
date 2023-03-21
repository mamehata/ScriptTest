using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack ()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence (int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic (int magic)
    {
        if (this.mp >= magic)
        {
            this.mp -= magic;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
