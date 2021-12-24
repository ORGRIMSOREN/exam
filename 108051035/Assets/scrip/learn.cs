
using UnityEngine;
/// <summary>
/// 學習運算子
/// 1.指定 =
/// 2.數學 + - * / % 遞減--遞增++
/// 3.比較 > < >= <= == !=
/// 4.邏輯 並且&& 或者|| 顛倒!
/// </summary>
public class learn : MonoBehaviour
{
    #region 指定運算子
    //指定運算子特性:
    //指定運算子先執行右邊在執行左邊
    //1+2=3
    public int number = 10;    //指定:將數字10指定給欄位number

    public float numberA = 10;
    public float numberB = 3;
    public int numberC = 30;
    public int numberD = 5;
    public int numberE = 9;
    public int numberF = 1;
    #endregion


    private void Start()
    {
        #region 數學運算子
        print("加法:" + (numberA + numberB));
        print("減法:" + (numberA - numberB));
        print("乘法:" + (numberA * numberB));
        print("除法" + (numberA / numberB));
        print("餘數" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC減1:" + numberC);
        numberC--;                   //遞減
        print("numberC減1:" + numberC);

        numberD = numberD + 10;
        print("numberD加10:" + numberD);
        numberD+=10;                   //遞增 指定 + - * / %
        print("numberD加10:" + numberD);
        #endregion
        #region 比較運算子
        //作用:比較兩個值，並且取得布林值結果
        print("E>F:" + (numberE > numberF));  //t
        print("E<F:" + (numberE < numberF));  //f
        print("E>=F:" + (numberE >= numberF));//t
        print("E<=F:" + (numberE <= numberF));//f
        print("E==F:" + (numberE == numberF));//f
        print("E!=F:" + (numberE !=numberF)); //t
        #endregion
        #region 邏輯運算子
        //作用:比較兩個布林值，並且取得布林值結果
        //並且:只要有一個False 結果為false
        print("T&&T:" + (true && true));    //t
        print("T&&F:" + (true && false));   //f
        print("F&&F:" + (false && false));  //f
        print("F&&T:" + (false && true));   //f
        //或者:只要有一個true 結果為true
        print("T||T:" + (true || true));    //t
        print("T||F:" + (true || false));   //t
        print("F||F:" + (false || false));  //f
        print("F||T:" + (false || true));   //t
        //顛倒:將布林值給相反
        print("!true:" + (!true));          //f
        print("!false" + (!false));         //t
        #endregion
    }
}
