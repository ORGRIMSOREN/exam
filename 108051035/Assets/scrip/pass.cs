using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class pass : MonoBehaviour
{
    //public ParticleSystem pickEffectP; 
    public GameObject pickE;
    public UnityEvent passpass;

    //【產生音效 1】
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {


        //【產生特效】


        if (collision.CompareTag("Player"))
        {
            Instantiate(pickE, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            passpass.Invoke();
        }
    }
}
