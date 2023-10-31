using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public static BallSpawn instance { get; private set; }

    [SerializeField] private GameObject ball;

    private float[] RandomY = { -3, -2, -1, 0, 1, 2, 3 };

    private int index;

    [HideInInspector] public GameObject BallClone;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        index = Random.Range(index, RandomY.Length);

        transform.position = new Vector3(0, RandomY[index]);
    }

    public void InstantiateBall()
    {
        BallClone = Instantiate(ball, transform.position, Quaternion.identity);
    }

}
