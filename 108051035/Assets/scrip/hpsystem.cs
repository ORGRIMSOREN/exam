using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpsystem : MonoBehaviour
{
    [Header("���")]
    public Image imgHpBar;
    [Header("��q")]
    public float hp = 100;
    float hpMax;
    private void Awake()
    {
        hpMax = hp;
    }

    public void Hurt(float damage)
    {
        hp -= damage;
        imgHpBar.fillAmount = hp / hpMax;
    }
}
