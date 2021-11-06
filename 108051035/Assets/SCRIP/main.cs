using UnityEngine;
/// <summary>
/// ¥D¨¤³]©w
/// </summary>
public class main : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Move = transform.position;
        Move.x = Move.x + Input.GetAxis("Horizontal") * moveSpeed;

        transform.position = Move;
    }
    
}
