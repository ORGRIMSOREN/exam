using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contoorller2d : MonoBehaviour
{
    #region 欄位 開放
    [Header("移動速度"), Range(0, 100)]
    public float speed =3.5f;
    [Header("跳躍高度"), Range(100, 500)]
    public float jump = 100;
    [Header("檢查地面")]
    [Range(0,1)]
    public float checkgroundradious = 0.1f;
    public Vector3 checkgroundoffset;
    [Header("可跳躍圖層與跳躍按鍵")]
    public KeyCode jumpkey=KeyCode.Space;
    public LayerMask canjumplayer;
    [Header("動畫參數")]
    public string anwalk="走路開關";
    public string anjumping="主角跳躍";
    #endregion
    #region 欄位私人
    [SerializeField]
    private bool isgrounded;
    private Rigidbody2D rig;
    private Animator ani;

    #endregion
    #region 事件
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkgroundoffset), checkgroundradious);
    }
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

   
    private void Update()
    {
        Flip();
        CheckingGround();
        jumping();
    }



    private void FixedUpdate()
    {

        move();
        
        
        
    }
    #endregion
    #region 方法
    private void move()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        //print("鍵盤數值="+Horizontal);
        float Vertical = Input.GetAxis("Vertical");
        rig.velocity = new Vector2(Horizontal * speed, rig.velocity.y);
        ani.SetBool(anwalk, Horizontal != 0);
    }
    
    
    private void  Flip()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        if(Horizontal<0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else if(Horizontal>=0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

        }
    }

    private void CheckingGround()
    {
        Collider2D checking=Physics2D.OverlapCircle(transform.position+
            transform.TransformDirection(checkgroundoffset), checkgroundradious,canjumplayer);
        //print("碰到的是:" + checking.name);
        isgrounded = checking;
    }
    private void jumping()
    {
        if(isgrounded&&Input.GetKeyDown(jumpkey))
        {

            rig.AddForce(new Vector2(0, jump));

        }
        ani.SetBool(anjumping, !isgrounded);
    }

    #endregion

}



