
using UnityEngine;
using UnityEngine.Events;

public class enmeny : MonoBehaviour
{
    #region 欄位
    [Header("追蹤目標範圍")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3OffeSet;
    [Header("攻擊目標範圍")]
    public Vector3 attackSize = Vector3.one;
    public Vector3 attackOffeSet;
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
    [Header("攻擊距離"),Range(0,30)]
    public float attackDistance=1.3f;
    [Header("攻擊冷卻"), Range(0, 10)]
    public float attackCd = 2.8f;
    float timerattack;
    public string attackani=("攻擊開關");
    public string walkani=("走路開關");
    public UnityEvent pass;

    #endregion

    #region 事件
    private void  OnDrawGizmos()
    {
        //繪製方形(中心,尺寸)
        Gizmos.color=new Color(1,0,0,0.3f);
        Gizmos.DrawCube(transform.position+transform.TransformDirection(v3OffeSet), v3TrackSize);
        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(attackOffeSet), attackSize);
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
        Collider2D playercome= Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3OffeSet), v3TrackSize,0, layerTarget);
        if (playercome)
        {
            move();
        }
    }
    private void move()
    {
        //三元運算子語法:布林值?當布林為true當布林為false;
        //如果目標x小於敵人的x就代表左邊角度=0
        //如果目標x大於敵人的x就代表右邊角度=180
        if(face.position.x>transform.position.x)
        {
            //angle = 180;
        }
        else if(face.position.x<transform.position.x)
        {
            //angle = 0;
        }
        angle = face.position.x > transform.position.x ?   180 :0;
        transform.eulerAngles = Vector3.up * angle;
        //攻擊距離偵測
        float distance = Vector3.Distance(face.position, transform.position);
        if (distance<=attackDistance)
        {
            rig.velocity = Vector3.zero;
            ani.SetBool(walkani, false);
            attack();
        }
        //print("目標距離" + distance);
        rig.velocity = transform.TransformDirection( new Vector2(-speed, rig.velocity.y));
        ani.SetBool(walkani, true);

        
    }
    [Header("攻擊力"), Range(0, 100)]
    public float damage = 100;
    void attack()
    {
        if (timerattack < attackCd)
        {
            timerattack += Time.deltaTime;

        }
        else
        {
            ani.SetTrigger(attackani);
            timerattack = 0;
            Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(attackOffeSet), attackSize, 0, layerTarget);
            hit.GetComponent<hpsystem>().Hurt(damage);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("magic")==true)
        {
            Destroy(gameObject);
            pass.Invoke();
        }
    }
    #endregion
}
