
using UnityEngine;
using System;
using UnityEngine.UI;


public class Slime : MonoBehaviour
{
    [Header("血量"), Tooltip("史萊姆血量")]
    [Range(150, 300)]
    public int 血量 = 150;

    [Header("攻擊力"), Tooltip("史萊姆血量")]
    [Range(10, 20)]
    public int 攻擊力 = 10;

    [Header("治癒量"), Tooltip("史萊姆血量")]
    [Range(10, 20)]
    public int 治癒量 = 20;

    [Header("文字:輸出結果")]

    public Text result;

    public Bat bat1;


    ///<summary>
    ///Slime attack
    ///</summary>
    public void Attack()
    {
        result.text = bat1.name + "受到了" + 攻擊力 + "的傷害";
        bat1.Hurt();
    }

    ///<summary>
    ///Slime hit
    ///</summary>
    public void Hurt()
    {
        int 總血量 = 血量 -= bat1.攻擊力;
        result.text = gameObject.name + "受到傷害"+"\n"+"目前血量" + 總血量;
    }
    /// <summary>
    /// Slime healing
    /// </summary>
    public void Healing()
    {
        result.text = gameObject.name + "回復了" + 治癒量 + "的血量"+"\n"
        +gameObject.name+"目前血量:"+(血量 += 治癒量);
    }

}
