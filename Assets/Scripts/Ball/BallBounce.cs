using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private BallMovement ballMovement;

    private void Awake()
    {
        ballMovement = GetComponent<BallMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            ballMovement.Direction = new Vector2(-ballMovement.Direction.x, ballMovement.Direction.y);
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            ballMovement.Direction = new Vector2(ballMovement.Direction.x, -ballMovement.Direction.y);
        }
    }
}
