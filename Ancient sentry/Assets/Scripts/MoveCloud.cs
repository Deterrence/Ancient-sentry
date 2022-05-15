using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
