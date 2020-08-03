using UnityEngine;

public class LearnDota : MonoBehaviour
{
    #region 欄位
    [Header("攻擊力"), Range(0, 1000)]
    public float attack = 10;
    [Header("防禦力"), Range(0, 1000)]
    public float Defense = 5;
    [Header("血量"), Range(0, 2000)]
    public float hp = 100;
    [Header("魔力"), Range(0, 2000)]
    public float mp = 100;
    public float 火球;
    public float skill_01;
    public float 冰球;
    public float skill_02;
    [Header("移動速度"),Range(0,500)]
    public float speed = 5;
    //是否死亡
    public bool isGround;

    #endregion
    #region 方法

    private void Start()
    {
        Shoot("火");
        Shoot("冰");
    }



    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        
    }
    /// <summary>
    /// 受傷
    /// </summary>
    private void Hit()
    { 
    
    }
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    { 
    
    }

    public void Shoot(string prop)
    {
        print("施放" + prop + "球!!!");
        print("執行動畫");
    }
    #endregion
}
