using UnityEngine;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal"); // Sa� - Sol (A-D / Sol-Sa� Ok)
        float moveY = Input.GetAxis("Vertical");   // �leri - Geri (W-S / Yukar�-A�a�� Ok)

        moveInput = new Vector2(moveX, moveY).normalized; // K��elerde h�zl� gitmeyi �nlemek i�in normalize ettik
        rb.linearVelocity = moveInput * speed; // Hareketi uygula
    }
}

