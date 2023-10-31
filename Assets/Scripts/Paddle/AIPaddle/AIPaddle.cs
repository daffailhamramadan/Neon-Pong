using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    private Vector2 ballPositionY;

    [SerializeField] private float speed;
    [SerializeField] private LayerMask ball;

    private void Update()
    {
        if(BallSpawn.instance.BallClone != null)
        {
            PaddleMovement();
        }
        
    }

    private void PaddleMovement()
    {
        ballPositionY = new Vector2(transform.position.x, BallSpawn.instance.BallClone.transform.position.y);

        if(Physics2D.OverlapBox(transform.position, new Vector2(18f, 10f), 10f, ball))
        {
            transform.position = Vector2.MoveTowards(transform.position, ballPositionY, speed * Time.deltaTime);
        }

        
    }

}
