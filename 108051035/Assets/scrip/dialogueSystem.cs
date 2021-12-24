using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
/// <summary>
/// ��ܨt��
/// </summary>
public class dialogueSystem : MonoBehaviour
{
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject goDialogue;
    [Header("��ܤ��e")]
    public Text textContent;
    [Header("��ܧ����ϥ�")]
    public GameObject goTip;
    [Header("��ܫ���")]
    public KeyCode keyDialogue = KeyCode.Mouse0;



    private void Start()
    {
        //StartCoroutine(TypeEffect());
    }
    private IEnumerator TypeEffect(string[] contents)
    {
        //string test1 = "���o~�A�n";
        //string test2 = "�ݧ���";

        //string[] contents = { test1, test2 };


        goDialogue.SetActive(true);

        for (int j = 0; j < contents.Length; j++)
        {
            textContent.text = "";
            goTip.SetActive(false);

            for (int i = 0; i < contents[j].Length; i++)
            {
                textContent.text += contents[j][i];
                yield return new WaitForSeconds(interval);

            }

            goTip.SetActive(true);
            while (!Input.GetKeyDown(keyDialogue))
            {
                yield return null;

            }

        }
        goDialogue.SetActive(false);


    }
    /// <summary>
    /// �}�l���
    /// </summary>
    /// <pram name="contents">�n��ܪ���r</pram>
    public void StartDialogue(string[]contents)
    {
        StartCoroutine(TypeEffect(contents));
    }
    public void StopDialogue()
    {
        StopAllCoroutines();
        goDialogue.SetActive(false);


    }

}

