using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // money��205�ŏ���������
        int money = 205;
        if (money <= 50)
        {
            // money��50�ȉ��������ꍇ�̏���
            Debug.Log("����𔄂�");
        }
        else if (money >= 200)
        {
            // money��200�ȏゾ�����ꍇ�̏���
            Debug.Log("����𔃂�");
        }
        else
        {
            // ����ȊO�̏ꍇ�̏���
            Debug.Log("�|�[�V�����𔃂�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
