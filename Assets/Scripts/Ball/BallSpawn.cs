using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    private float[] RandomY = { -3, -2, -1, 0, 1, 2, 3 };

    private int index;

    [HideInInspector] public GameObject BallClone

    void Start()
    {
        index = Random.Range(index, RandomY.Length);

        transform.position = new Vector3(0, RandomY[index]);

        InstantiateBall();
    }

    public void InstantiateBall()
    {
        BallClone = Instantiate(ball, transform.position, Quaternion.identity);
    }

}
