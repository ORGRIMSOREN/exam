
using UnityEngine;

public class enmeny : MonoBehaviour
{
    #region 欄位
    [Header("追蹤目標範圍")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3OffeSet;
    [Header("攻擊目標範圍")]
    public Vector3 v3attackSize = Vector3.one;
    public Vector3 v3attackOffeSet;
    [Header("移動速度")]
    public float speed = 1.5f;
    [Header("目標圖層")]
    public LayerMask layerTarget;
    public bool fuckingPlayer;
    private Rigidbody2D rig;
    [Header("動畫播放")]
    public Animator ani;
    [Header("面向方向")]
    public Transform face;
    private float angle = 0;
    [Header("攻擊距離"), Range(0, 5)]
    public float attackDistance = 1.3f;
    [Header("攻擊冷卻")]
    public float attackcd = 1.5f;
    public string AniAttack="attack";
    public float timerattack;
    #endregion

    #region 事件
    private void OnDrawGizmos()
    {
        //繪製方形(中心,尺寸)
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
    #region 方法
    private void CheckAttack()
    {
        //檢查目標是否進入攻擊範圍(中心,尺寸,角度)
        Collider2D playercome = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3OffeSet), v3TrackSize, 0, layerTarget);
        if (playercome)
        {
            move();
        }
        if (!playercome)
        {
            ani.SetBool("走路", false);

        }
    }
    private void move()
    {
        //三元運算子語法:布林值?當布林為true當布林為false;
        //如果目標x小於敵人的x就代表左邊角度=0
        //如果目標x大於敵人的x就代表右邊角度=180
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
        print("目標距離" + distance);
        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));
        ani.SetBool("走路", true);


        if (distance <= attackDistance)
        {
            rig.velocity = Vector3.zero;
            Attack();
        }
    }
    [Header("攻擊力"), Range(0, 100)]
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

