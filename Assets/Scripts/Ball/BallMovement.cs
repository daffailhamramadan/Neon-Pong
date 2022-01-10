using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    private int[] RandomX = { -1, 1 };

    private int[] RandomY = { -1, 1 };

    private int[] index = new int[2];

    [SerializeField] private float speed;

    public Vector2 Direction
    {
        get;

        set;
    }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        index[0] = Random.Range(index[0], RandomX.Length);

        index[1] = Random.Range(index[1], RandomY.Length);

        Direction = new Vector2(RandomX[index[0]], RandomY[index[1]]);
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = Direction * speed;
    }
}
