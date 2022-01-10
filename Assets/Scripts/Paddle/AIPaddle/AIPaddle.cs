using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    [SerializeField] private BallSpawn ballSpawn;

    private Vector2 ballPositionY;

    [SerializeField] private float speed;

    private void Update()
    {
        if(ballSpawn.BallClone != null)
        {
            PaddleMovement();
        }
        
    }

    private void PaddleMovement()
    {
        ballPositionY = new Vector2(transform.position.x, ballSpawn.BallClone.transform.position.y);

        transform.position = Vector2.MoveTowards(transform.position, ballPositionY, speed * Time.deltaTime);
    }
}
