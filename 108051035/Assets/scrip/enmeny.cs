
using UnityEngine;

public class enmeny : MonoBehaviour
{
    #region ���
    [Header("�l�ܥؼнd��")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3OffeSet;
    [Header("�����ؼнd��")]
    public Vector3 v3attackSize = Vector3.one;
    public Vector3 v3attackOffeSet;
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
    [Header("�����Z��"), Range(0, 5)]
    public float attackDistance = 1.3f;
    [Header("�����N�o")]
    public float attackcd = 1.5f;
    public string AniAttack="attack";
    public float timerattack;
    #endregion

    #region �ƥ�
    private void OnDrawGizmos()
    {
        //ø�s���(����,�ؤo)
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3OffeSet), v3TrackSize);
        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3attackOffeSet), v3attackSize);
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
        Collider2D playercome = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3OffeSet), v3TrackSize, 0, layerTarget);
        if (playercome)
        {
            move();
        }
        if (!playercome)
        {
            ani.SetBool("����", false);

        }
    }
    private void move()
    {
        //�T���B��l�y�k:���L��?���L��true���L��false;
        //�p�G�ؼ�x�p��ĤH��x�N�N���䨤��=0
        //�p�G�ؼ�x�j��ĤH��x�N�N��k�䨤��=180
        if (face.position.x > transform.position.x)
        {
            //angle = 180;
        }
        else if (face.position.x < transform.position.x)
        {
            //angle = 0;
        }
        angle = face.position.x > transform.position.x ? 180 : 0;
        transform.eulerAngles = Vector3.up * angle;

        float distance = Vector3.Distance(face.position, transform.position);
        print("�ؼжZ��" + distance);
        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));
        ani.SetBool("����", true);


        if (distance <= attackDistance)
        {
            rig.velocity = Vector3.zero;
            Attack();
        }
    }
    [Header("�����O"), Range(0, 100)]
    public float damage = 35;
    void Attack()
        {
            if (timerattack < attackcd)
            {
                timerattack += Time.deltaTime;

            }
            else
            {
                ani.SetTrigger(AniAttack);
                timerattack = 0;
            Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3attackOffeSet), v3attackSize, 0, layerTarget);
            hit.GetComponent<Hp>().hurt(damage);
        }
        }
    }
    #endregion

