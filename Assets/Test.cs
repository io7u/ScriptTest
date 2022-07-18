using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    // Start is called before the first frame update
  public class Boss
{
    
        private int hp = 100;   //体力
        private int power = 25;//攻撃力
        private int mp = 53;//魔法MP
       
        //攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }
        //防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            //残りhpを減らす
            this.hp -= damage;
        }
        //Magic関数
        public void Magic()
        {
            if (mp >= 5)
            {
                mp = mp - 5;
                
                Debug.Log("魔法攻撃をした。残りMPは" + mp+"。");
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
         }

    }
public class Test : MonoBehaviour
{
    void Start()
    {
        


        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss middleboss = new Boss();

        //攻撃用の関数を呼び出す
        middleboss.Attack();
        //防御用の関数を呼び出す
        middleboss.Defence(7);

        //Magic関数を10回使った後
        for(int n =0; n < 10; n++)
        {
            lastboss.Magic();
        }
        lastboss.Magic();
       
        int[] array = new int[5];
        //配列の各要素に値を代入する
        array[0] = 1;
        array[1] = 3;
        array[2] = 5;
        array[3] = 7;
        array[4] = 9;

        //配列の要素を順番に表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //配列の要素を逆順に表示する
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
