using UnityEngine;
/// <summary>
/// 記憶碎片基礎設定
/// </summary>
public class book : MonoBehaviour
{
    //數量
    [Header("記憶碎片數量"), Range(0, 4)]
    public int 蒐集數量 = 1;
    [Header("是否使用碎片")]   
    public bool 使用 = true;

}