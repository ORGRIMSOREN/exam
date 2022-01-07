using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{
    [Header("���")]
    public Image imgHp;
    [Header("��q")]
    public float hp = 100;
    [Header("���`�ʵe")]
    public string aniDead = "���`";


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
