using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    // Start is called before the first frame update
  public class Boss
{
    
        private int hp = 100;   //�̗�
        private int power = 25;//�U����
        private int mp = 53;//���@MP
       
        //�U���p�̊֐�
        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }
        //�h��p�̊֐�
        public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            //�c��hp�����炷
            this.hp -= damage;
        }
        //Magic�֐�
        public void Magic()
        {
            if (mp >= 5)
            {
                mp = mp - 5;
                
                Debug.Log("���@�U���������B�c��MP��" + mp+"�B");
            }
            else
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
         }

    }
public class Test : MonoBehaviour
{
    void Start()
    {
        


        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //�U���p�̊֐����Ăяo��
        lastboss.Attack();
        //�h��p�̊֐����Ăяo��
        lastboss.Defence(3);

        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss middleboss = new Boss();

        //�U���p�̊֐����Ăяo��
        middleboss.Attack();
        //�h��p�̊֐����Ăяo��
        middleboss.Defence(7);

        //Magic�֐���10��g������
        for(int n =0; n < 10; n++)
        {
            lastboss.Magic();
        }
        lastboss.Magic();
       
        int[] array = new int[5];
        //�z��̊e�v�f�ɒl��������
        array[0] = 1;
        array[1] = 3;
        array[2] = 5;
        array[3] = 7;
        array[4] = 9;

        //�z��̗v�f�����Ԃɕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //�z��̗v�f���t���ɕ\������
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
