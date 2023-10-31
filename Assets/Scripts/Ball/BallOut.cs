using UnityEngine;

public class BallOut : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Out"))
        {
            GameController.instance.AddEnemyScore(1);

            if(GameController.instance.gameState == GameController.GameState.Play && GameController.instance.EnemyScore <= 9)
            {
                BallSpawn.instance.InstantiateBall();
            }
            
        }
        else
        {
            GameController.instance.AddPlayerScore(1);

            if (GameController.instance.gameState == GameController.GameState.Play && GameController.instance.PlayerScore <= 9)
            {
                BallSpawn.instance.InstantiateBall();
            }
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
