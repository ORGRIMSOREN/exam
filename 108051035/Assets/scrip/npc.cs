using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// npc行為
/// </summary>

public class npc : MonoBehaviour
{
    [Header("對話資料")]
    public datadialogue datadialogue;
    [Header("對話系統")]
    public dialogueSystem dialogueSystem;
    [Header("對話對象")]
    public string traget = "小恐龍";




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name==traget)
        {

            dialogueSystem.StartDialogue(datadialogue.dialogues);


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name==traget)
        {
            dialogueSystem.StopDialogue();

        }
    }
}
