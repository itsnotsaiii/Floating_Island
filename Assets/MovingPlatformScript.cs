using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 3f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.Sin(Time.time * speed) * moveDistance;
        transform.position = startPosition + new Vector3(movement, 0, 0);
    }
}