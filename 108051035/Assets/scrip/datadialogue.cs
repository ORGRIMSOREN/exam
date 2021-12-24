using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="SOREN/對話資料")]
public class datadialogue : ScriptableObject

{
    [Header("對話內容"), TextArea(3, 5)]
    public string[] dialogues;

}
