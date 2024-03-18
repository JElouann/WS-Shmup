using UnityEngine;

public class EnemyDodge : MonoBehaviour
{
    private float amp = 6f;
    private float fre = 1f;

    private void FixedUpdate()
    {
        Vector2 position = transform.position;

        float sin = Mathf.Sin(position.y * fre ) * amp;
        position.x = sin;

        transform.position = position;
    }
}
