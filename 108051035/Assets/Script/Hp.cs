using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    [Header("血條")]
    public Image imgHp;
    [Header("血量")]
    public float hp = 100;
    [Header("死亡動畫")]
    public string aniDead = "死亡";


    private float hpmax;
    private Animator ani;
   public void Awake()
    {
        hpmax=hp;
        ani = GetComponent<Animator>();

    }
    public void hurt(float damage)
    {
        hp -= damage;
        imgHp.fillAmount = hp / hpmax;
        if (hp <= 0) Dead();
        

    
    }

    void Dead()
    {
        ani.SetTrigger(aniDead);
    }
}
