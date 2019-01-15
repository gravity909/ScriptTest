using UnityEngine;
using System.Collections;

public class Boss
{
    public int mp = 3;          // マジックポイント
    
    // 魔法攻撃用の関数
    public int Magic(int consumption)
    {
        // 残りmpを減らす
        this.mp -= consumption;

        if (mp > 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }

        return mp;
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss magicattack = new Boss();

        // 魔法攻撃用の関数を呼び出す
        magicattack.mp = magicattack.Magic(5);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}