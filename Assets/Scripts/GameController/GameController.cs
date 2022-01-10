using UnityEngine;

public class GameController : MonoBehaviour
{
    public int PlayerScore
    {
        get;

        private set;
    }

    public int EnemyScore
    {
        get;

        private set;
    }

    public void AddPlayerScore (int score)
    {
        PlayerScore += score;
    }

    public void AddEnemyScore(int score)
    {
        EnemyScore += score;
    }

}
