using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpsystem : MonoBehaviour
{
    [Header("¦å±ø")]
    public Image imgHpBar;
    [Header("¦å¶q")]
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
