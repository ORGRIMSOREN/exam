using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
/// <summary>
/// 對話系統
/// </summary>
public class dialogueSystem : MonoBehaviour
{
    [Header("對話間隔"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("畫布對話系統")]
    public GameObject goDialogue;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話完成圖示")]
    public GameObject goTip;
    [Header("對話按鍵")]
    public KeyCode keyDialogue = KeyCode.Mouse0;



    private void Start()
    {
        //StartCoroutine(TypeEffect());
    }
    private IEnumerator TypeEffect(string[] contents)
    {
        //string test1 = "哈囉~你好";
        //string test2 = "看屁阿";

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
    /// 開始對話
    /// </summary>
    /// <pram name="contents">要顯示的文字</pram>
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

