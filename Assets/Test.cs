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
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Defence (int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= damage;
    }

    public void Magic (int magic)
    {
        if (this.mp >= magic)
        {
            this.mp -= magic;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
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
