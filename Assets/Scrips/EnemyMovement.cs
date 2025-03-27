using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3f;
    public float minY = -3f;
    public float maxY = 3f;
    private int direction = 1;

    void Update()
    {
        transform.Translate(Vector3.up * speed * direction * Time.deltaTime);

        if (transform.position.y >= maxY)
            direction = -1;
        else if (transform.position.y <= minY)
            direction = 1;
    }
}
