using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    public int mp = 53;          // マジックポイント

    // Use this for initialization
    void Start()
    {
        // 配列を初期化する
        int[] points = { 30, 20, 50, 10, 80};

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < points.Length; i++)
        {
             // 配列の要素を表示する
             Debug.Log(points[i]);
        }

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = points.Length - 1; i >= 0; i--)
        {
            // 配列の要素を表示する
            Debug.Log(points[i]);
        }
               
    }

    // Update is called once per frame
    void Update()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss magicattack = new Boss();
        // 魔法攻撃用の関数を呼び出す
        mp = magicattack.Magic(5,mp);
    }

    public class Boss
    {
    
        // 魔法攻撃用の関数
        public int Magic(int consumption, int mp)
        {
            // 残りmpを減らす
            mp -= consumption;

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
}