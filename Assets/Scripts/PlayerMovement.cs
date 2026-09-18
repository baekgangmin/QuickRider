using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        Vector2 direction = Vector2.zero;
        if (keyboard.upArrowKey.isPressed) direction.y += 1f;
        if (keyboard.downArrowKey.isPressed) direction.y -= 1f;
        if (keyboard.leftArrowKey.isPressed) direction.x -= 1f;
        if (keyboard.rightArrowKey.isPressed) direction.x += 1f;

        rb.linearVelocity = direction.normalized * moveSpeed;
    }
}
