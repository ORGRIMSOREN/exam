using UnityEngine;             //�ޥ�Unity�����R�W�Ŷ�

//������
//�~�H 2021
//class ���O:�@�Ӫ����Ź�
//�y�k:���O�W��{���O���e(���O����)}
//�����O�n�bUnity���ϥΥ����~��MonoBehaviour

public class Car : MonoBehaviour
{
    #region ���y�k�P�|�j�`������
    //���Field:�O�s�U�������
    //�y�k:������� ���W�� ���w �w�]�� �����Ÿ�
    // �|�j�`������:
    //���:�x�s�S���p���I�����t��-int
    //�B�I��:�x�s���p���I�����t��-float
    //�r��:�x�s��r��T         -string
    //���L��:�O�P�_ true�Bfalse -bool
    //�׹���
    //�p�H:�~������s�� �����private(�w�]��)
    //���}:�~���i�H�s�� ���  publiv
    //����ݩ� Attritube
    //�y�k:[�ݩʦW��(��)]
    //1.���D Header(�r��)
    //2.���� Tooltip(�r��)
    //3.�d�� Range(�̤p�ȡE�̤j��)

    [Header("CC ��"), Range(500, 5000)]
    public int cc = 1000;
    [Header("���q"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("�~�P"), Tooltip("�o�O���l���~�P�W��")]
    public string brand = "���h";
    [Header("�O�_���ѵ�")]
    public bool hasSkyWindow = true;
    #endregion
    #region Unity���������
    //�C��,�V�q(�y��),����,�C������,����
    //�C��color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color ColorCustom2 = new Color(1, 0, 1, 0.5f);
    //�V�q 2~4vrctor
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 V2Right = Vector2.right;
    public Vector2 V2left = Vector2.left;
    public Vector2 V2Custom = new Vector2(1, 2);
    //����  Keycode 
    public KeyCode keycode;
    public KeyCode kecodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeJump = KeyCode.Space;
    //�C������ GameObject
    public GameObject goCamera;
    public GameObject gocar;
    //���� Component
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer spr;



    #endregion
    #region �ƥ�:�{���J�f
    //�}�l�ƥ�:�C������ɰ���@��
    private void Start()
    {
        //�I�s��k:��k�W��();
        Test();
        Drive80();
        Drive100();
        Drive(120);

    }
    #endregion
    #region ��k�y�k
    //��k:�O�s�������e���϶��A�t��k�A���z��
    //�y�k:�׹��� �Ǧ^���� ��k�W�� (�Ѽ�1�A�Ѽ�2....�Ѽ�n) {�{�����e}
    //void �L�Ǧ^:�ϥΤ�k�ɤ��Ǧ^���
    private void Test()
    {
        //��X(�T��)-�N�T����X��Unity����O consle
        print("���o�A�U�w :D");
    }
    private void Drive80()
    {
        print("�}���ɳt" + 80);

    }
    private void Drive100()
    {
        print("�}���ɳt" + 100);



    }
    //�Ѽƻy�k:������� �ѼƦW��
    private void Drive(int speed)
    {
        print("�}���ɳt:" + speed);
        print("����:������");


    }

    private float ConvertWeight(float setWeight)
    {
      return setWeight * 50;

    }
   


    #endregion
}