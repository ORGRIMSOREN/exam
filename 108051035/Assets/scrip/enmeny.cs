
using UnityEngine;

public class enmeny : MonoBehaviour
{
    #region ���
    [Header("�l�ܥؼнd��")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3OffeSet;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    public bool fuckingPlayer;
    private Rigidbody2D rig;
    [Header("�ʵe����")]
    public Animator ani;
    [Header("���V��V")]
    public Transform face;
    private float angle = 0;
    #endregion
    
    #region �ƥ�
    private void  OnDrawGizmos()
    {
        //ø�s���(����,�ؤo)
        Gizmos.color=new Color(1,0,0,0.3f);
        Gizmos.DrawCube(transform.position+transform.TransformDirection(v3OffeSet), v3TrackSize);
    }
    void Update()
    {
        CheckAttack();
    }
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();

    }

    #endregion
    #region ��k
    private void CheckAttack()
    {
        //�ˬd�ؼЬO�_�i�J�����d��(����,�ؤo,����)
        Collider2D playercome= Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3OffeSet), v3TrackSize,0, layerTarget);
        if (playercome)
        {
            move();
        }
    }
    private void move()
    {
        //�T���B��l�y�k:���L��?���L��true���L��false;
        //�p�G�ؼ�x�p��ĤH��x�N�N���䨤��=0
        //�p�G�ؼ�x�j��ĤH��x�N�N��k�䨤��=180
        if(face.position.x>transform.position.x)
        {
            //angle = 180;
        }
        else if(face.position.x<transform.position.x)
        {
            //angle = 0;
        }
        angle = face.position.x > transform.position.x ?   0 :180;
        transform.eulerAngles = Vector3.up * angle;

        float distance = Vector3.Distance(face.position, transform.position);
        //print("�ؼжZ��" + distance);
        rig.velocity = transform.TransformDirection( new Vector2(speed, rig.velocity.y));
        ani.SetBool("����", true);
    }
    #endregion
}
