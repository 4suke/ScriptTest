using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Boss
{
    private int mp = 53;          // MP
    private int use = 5; // 消費MP
    bool result = true; //魔法成否

    // 魔法用の関数
    public void Magic()
    {
        for (int mp = this.mp; result == true; mp -= this.use)
        {
            if (mp >= use) {
                int used = mp - use; //魔法使用後のMP
                Debug.Log("魔法攻撃をした。残りMPは" + used + "。");
                result = true;
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
                result = false;
            }
        }
        
    }

 

}

public class Test : MonoBehaviour
{

    void Start()
    {
        int a = 5;
        int[] array = new int[a];
        array[0] = 140;
        array[1] = 250;
        array[2] = 690;
        array[3] = 540;
        array[4] = 760;
        for (int i = 0; i < a; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = a - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }


        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 魔法用の関数を呼び出す
        lastboss.Magic();
      
    }

    // Update is called once per frame
    void Update()
    {

    }
}
