
using UnityEngine;
using System;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{

    [Header("血量"),Tooltip("蝙蝠血量")]
    [Range(150,300)]
    public int 血量 = 200;
    
    [Header("攻擊力"), Tooltip("蝙蝠攻擊力")]
    [Range(10, 20)]
    public int 攻擊力 = 20;

    [Header("治癒量"), Tooltip("蝙蝠治癒量")]
    [Range(10, 20)]
    public int 治癒量 = 10;

   
    [Header("文字:輸出結果")]
    public Text result;

    public Slime slime1;

    ///<summary>
    ///Bat attack
    ///</summary>
    public void  Attack()
    {
        result.text = slime1.name + "受到了" + 攻擊力 + "的傷害";
        slime1.Hurt();
    }

    ///<summary>
    ///Bat hit
    ///</summary>
    public void  Hurt()
    {
        int 總血量 = 血量 -= slime1.攻擊力;
        result.text = gameObject.name + "受到傷害" + "\n" + "目前血量" + 總血量;
    }
    /// <summary>
    /// Bat healing
    /// </summary>
    public void  Healing()
    {
        result.text = gameObject.name + "回復了" + 治癒量 + "的血量"+"\n"
        + gameObject.name + "目前血量:" + (血量 += 治癒量);
    }
   
}

