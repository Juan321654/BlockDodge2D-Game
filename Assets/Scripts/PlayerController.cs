using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 targetPosition;
    private bool isMoving = false;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float stoppingDistance = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.tag = TagManager.Tags.Player.ToString();
    }

    void Update()
    {
        HandleInput();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void HandleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMoving = true;
        }
    }

    void MovePlayer()
    {
        if (isMoving)
        {
            Vector2 currentPosition = rb.position;
            Vector2 direction = (targetPosition - currentPosition).normalized;
            float distanceToTarget = Vector2.Distance(currentPosition, targetPosition);

            if (distanceToTarget < stoppingDistance)
            {
                isMoving = false;
                rb.velocity = Vector2.zero;
            }
            else
            {
                // Use MovePosition for smoother movement
                Vector2 newPosition = Vector2.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.fixedDeltaTime);
                rb.MovePosition(newPosition);
            }
        }
    }
}
