using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class pass : MonoBehaviour
{
    //public ParticleSystem pickEffectP; 
    public GameObject pickE;
    public UnityEvent passpass;

    //�i���ͭ��� 1�j
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {


        //�i���ͯS�ġj


        if (collision.CompareTag("Player"))
        {
            Instantiate(pickE, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            passpass.Invoke();
        }
    }
}
