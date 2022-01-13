using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    private int[] RandomX = { -1, 1 };

    private int[] RandomY = { -1, 1 };

    private int[] index = new int[2];

    [SerializeField] private float speed;

    [HideInInspector] public Vector2 Direction;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        for(int i=0; i < index.Length; i++)
        {
            index[i] = Random.Range(index[i], RandomX.Length);
        }

        Direction = new Vector2(RandomX[index[0]], RandomY[index[1]]);
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = Direction * speed;
    }
}
