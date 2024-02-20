using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;
    public Transform target; // Player's transform

    private void Update()
    {
        // Move towards the player
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
