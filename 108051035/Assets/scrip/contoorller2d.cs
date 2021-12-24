using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contoorller2d : MonoBehaviour
{
    #region ��� �}��
    [Header("���ʳt��"), Range(0, 100)]
    public float speed =3.5f;
    [Header("���D����"), Range(100, 500)]
    public float jump = 100;
    [Header("�ˬd�a��")]
    [Range(0,1)]
    public float checkgroundradious = 0.1f;
    public Vector3 checkgroundoffset;
    [Header("�i���D�ϼh�P���D����")]
    public KeyCode jumpkey=KeyCode.Space;
    public LayerMask canjumplayer;
    [Header("�ʵe�Ѽ�")]
    public string anwalk="�����}��";
    public string anjumping="�D�����D";
    #endregion
    #region ���p�H
    [SerializeField]
    private bool isgrounded;
    private Rigidbody2D rig;
    private Animator ani;

    #endregion
    #region �ƥ�
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
    #region ��k
    private void move()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        //print("��L�ƭ�="+Horizontal);
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
        //print("�I�쪺�O:" + checking.name);
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



