using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magic : MonoBehaviour
{
    public float Speed = 5f;
    
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
        
       

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bad")==true)
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
