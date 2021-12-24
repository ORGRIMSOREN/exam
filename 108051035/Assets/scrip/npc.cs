using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// npc�欰
/// </summary>

public class npc : MonoBehaviour
{
    [Header("��ܸ��")]
    public datadialogue datadialogue;
    [Header("��ܨt��")]
    public dialogueSystem dialogueSystem;
    [Header("��ܹ�H")]
    public string traget = "�p���s";




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
