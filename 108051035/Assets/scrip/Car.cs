using UnityEngine;             //引用Unity引擎命名空間

//單行註解
//獸人 2021
//class 類別:一個物件的藍圖
//語法:類別名稱{類別內容(類別成員)}
//此類別要在Unity內使用必須繼承MonoBehaviour

public class Car : MonoBehaviour
{
    #region 欄位語法與四大常用類型
    //欄位Field:保存各類型資料
    //語法:資料類型 欄位名稱 指定 預設值 結束符號
    // 四大常見類型:
    //整數:儲存沒有小數點的正負數-int
    //浮點數:儲存有小數點的正負數-float
    //字串:儲存文字資訊         -string
    //布林值:是與否 true、false -bool
    //修飾詞
    //私人:外部不能存取 不顯示private(預設值)
    //公開:外部可以存取 顯示  publiv
    //欄位屬性 Attritube
    //語法:[屬性名稱(值)]
    //1.標題 Header(字串)
    //2.提示 Tooltip(字串)
    //3.範圍 Range(最小值‧最大值)

    [Header("CC 數"), Range(500, 5000)]
    public int cc = 1000;
    [Header("重量"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("品牌"), Tooltip("這是車子的品牌名稱")]
    public string brand = "賓士";
    [Header("是否有天窗")]
    public bool hasSkyWindow = true;
    #endregion
    #region Unity內資料類型
    //顏色,向量(座標),按鍵,遊戲物件,元件
    //顏色color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color ColorCustom2 = new Color(1, 0, 1, 0.5f);
    //向量 2~4vrctor
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 V2Right = Vector2.right;
    public Vector2 V2left = Vector2.left;
    public Vector2 V2Custom = new Vector2(1, 2);
    //按鍵  Keycode 
    public KeyCode keycode;
    public KeyCode kecodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeJump = KeyCode.Space;
    //遊戲物件 GameObject
    public GameObject goCamera;
    public GameObject gocar;
    //元件 Component
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer spr;



    #endregion
    #region 事件:程式入口
    //開始事件:遊戲播放時執行一次
    private void Start()
    {
        //呼叫方法:方法名稱();
        Test();
        Drive80();
        Drive100();
        Drive(120);

    }
    #endregion
    #region 方法語法
    //方法:保存城市內容的區塊，演算法，陳述式
    //語法:修飾詞 傳回類型 方法名稱 (參數1，參數2....參數n) {程式內容}
    //void 無傳回:使用方法時不傳回資料
    private void Test()
    {
        //輸出(訊息)-將訊息輸出至Unity儀表板 consle
        print("哈囉，沃德 :D");
    }
    private void Drive80()
    {
        print("開車時速" + 80);

    }
    private void Drive100()
    {
        print("開車時速" + 100);



    }
    //參數語法:資料類型 參數名稱
    private void Drive(int speed)
    {
        print("開車時速:" + speed);
        print("音效:咻咻咻");


    }

    private float ConvertWeight(float setWeight)
    {
      return setWeight * 50;

    }
   


    #endregion
}