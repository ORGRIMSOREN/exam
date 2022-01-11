using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bookpick : MonoBehaviour
{
    int books = 0;
    public Text booksno;
    // Start is called before the first frame update
    void Start()
    {
        AddScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScores()
    {
        books += 1;
        booksno.text = "»`¶°¼Æ:" + books;
    }
}
