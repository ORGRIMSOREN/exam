using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 可收集寶物＋【產生特效】＋【產生音效】
/// </summary>
public class Collectable : MonoBehaviour
{
    //public ParticleSystem pickEffectP; 
    public GameObject pickE;
    
    //【產生音效 1】
    public AudioClip audioClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        //【產生特效】
       

        if (collision.CompareTag("Player"))
        {
            Instantiate(pickE, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
        

        //【產生音效 2】
        //PlaySound(audioClip);

        
    }

    
}
