
using UnityEngine;
/// <summary>
/// �ǲ߹B��l
/// 1.���w =
/// 2.�ƾ� + - * / % ����--���W++
/// 3.��� > < >= <= == !=
/// 4.�޿� �åB&& �Ϊ�|| �A��!
/// </summary>
public class learn : MonoBehaviour
{
    #region ���w�B��l
    //���w�B��l�S��:
    //���w�B��l������k��b���楪��
    //1+2=3
    public int number = 10;    //���w:�N�Ʀr10���w�����number

    public float numberA = 10;
    public float numberB = 3;
    public int numberC = 30;
    public int numberD = 5;
    public int numberE = 9;
    public int numberF = 1;
    #endregion


    private void Start()
    {
        #region �ƾǹB��l
        print("�[�k:" + (numberA + numberB));
        print("��k:" + (numberA - numberB));
        print("���k:" + (numberA * numberB));
        print("���k" + (numberA / numberB));
        print("�l��" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC��1:" + numberC);
        numberC--;                   //����
        print("numberC��1:" + numberC);

        numberD = numberD + 10;
        print("numberD�[10:" + numberD);
        numberD+=10;                   //���W ���w + - * / %
        print("numberD�[10:" + numberD);
        #endregion
        #region ����B��l
        //�@��:�����ӭȡA�åB���o���L�ȵ��G
        print("E>F:" + (numberE > numberF));  //t
        print("E<F:" + (numberE < numberF));  //f
        print("E>=F:" + (numberE >= numberF));//t
        print("E<=F:" + (numberE <= numberF));//f
        print("E==F:" + (numberE == numberF));//f
        print("E!=F:" + (numberE !=numberF)); //t
        #endregion
        #region �޿�B��l
        //�@��:�����ӥ��L�ȡA�åB���o���L�ȵ��G
        //�åB:�u�n���@��False ���G��false
        print("T&&T:" + (true && true));    //t
        print("T&&F:" + (true && false));   //f
        print("F&&F:" + (false && false));  //f
        print("F&&T:" + (false && true));   //f
        //�Ϊ�:�u�n���@��true ���G��true
        print("T||T:" + (true || true));    //t
        print("T||F:" + (true || false));   //t
        print("F||F:" + (false || false));  //f
        print("F||T:" + (false || true));   //t
        //�A��:�N���L�ȵ��ۤ�
        print("!true:" + (!true));          //f
        print("!false" + (!false));         //t
        #endregion
    }
}