using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector3 startPosition; // Lưu vị trí ban đầu của Player

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position; // Gán vị trí ban đầu của Player
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput.normalized * moveSpeed;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy")) // Nếu chạm vào quái
        {
            Debug.Log("Player chạm vào Enemy! Quay về vị trí ban đầu.");
            transform.position = startPosition; // Đưa Player về vị trí ban đầu
        }
    }
}
