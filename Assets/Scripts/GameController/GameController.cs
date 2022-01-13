using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector] public int PlayerScore;

    [HideInInspector] public int EnemyScore; 

    public void AddPlayerScore (int score)
    {
        PlayerScore += score;
    }

    public void AddEnemyScore(int score)
    {
        EnemyScore += score;
    }

}
