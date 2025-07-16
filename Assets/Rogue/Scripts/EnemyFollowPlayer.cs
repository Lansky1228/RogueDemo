using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;
    void Update()
    {
        if (player != null)
        {
            Vector3 dir = (player.position - transform.position).normalized;
            dir.y = 0; // 不上下移動
            transform.Translate(dir * speed * Time.deltaTime, Space.World);
        }
    }
}