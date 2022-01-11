using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class hpsystem : MonoBehaviour
{
    [Header("血條")]
    public Image imgHpBar;
    [Header("血量")]
    public float hp = 100;
    float hpMax;
    [Header("死亡事件")]
    public UnityEvent OnDead;
    [Header("動畫參數")]
    public string isdead=("觸發死亡");
    public Animator ani;
    private void Awake()
    {
        hpMax = hp;
        ani = GetComponent<Animator>();
    }

    public void Hurt(float damage)
    {
        hp -= damage;
        imgHpBar.fillAmount = hp / hpMax;
        if (hp <= 0) Dead();
        
    }
    void   Dead()
    {
        ani.SetTrigger(isdead);
        OnDead.Invoke();
        
    }
}
