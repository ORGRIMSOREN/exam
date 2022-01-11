using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class hpsystem : MonoBehaviour
{
    [Header("���")]
    public Image imgHpBar;
    [Header("��q")]
    public float hp = 100;
    float hpMax;
    [Header("���`�ƥ�")]
    public UnityEvent OnDead;
    [Header("�ʵe�Ѽ�")]
    public string isdead=("Ĳ�o���`");
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
