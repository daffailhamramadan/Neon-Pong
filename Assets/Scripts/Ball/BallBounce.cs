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
        AudioManager.instance.BallHitSFX();

        ballMovement.Direction = Vector2.Reflect(ballMovement.Direction, collision.GetContact(0).normal);
    }
}
