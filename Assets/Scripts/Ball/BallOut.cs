using UnityEngine;

public class BallOut : MonoBehaviour
{
    private GameController gameController;

    private BallSpawn ballSpawn;

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        ballSpawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<BallSpawn>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Out"))
        {
            gameController.AddEnemyScore(1);

            ballSpawn.InstantiateBall();
        }
        else
        {
            gameController.AddPlayerScore(1);

            ballSpawn.InstantiateBall();
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
