using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float eMoveSpeed = 2f;
    private Rigidbody2D eRb;

    private Transform checkpoint;

    private int index = 0;
    void Awake()
    {
        eRb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        checkpoint = EnemyManager.main.checkpoint[index];
    }

    private void Update()
    {
        checkpoint = EnemyManager.main.checkpoint[index];


        if (Vector2.Distance(checkpoint. transform.position, transform.position) <= 0.1f )
        {
            index++;
            if (index >= EnemyManager.main.checkpoint.Length)
            {
                Destroy(gameObject);
            }
        }
    }
    void FixedUpdate()
    {
        Vector2 direction = (checkpoint.position - transform.position).normalized;


        //looks at destination
        transform.right = checkpoint.position - transform.position;

        eRb.linearVelocity = direction * eMoveSpeed;
    }
}
