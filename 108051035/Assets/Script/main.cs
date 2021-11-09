using UnityEngine;
/// <summary>
/// ¥D¨¤³]©w
/// </summary>
public class main : MonoBehaviour
{
    private float moveSpeed=0.05f;
    public Rigidbody2D Rb;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Move = transform.position;
        Move.x = Move.x + Input.GetAxis("Horizontal") * moveSpeed;

        Rb.position = Move;
    }
    
}
