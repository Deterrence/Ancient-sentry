using UnityEngine;

public class MoveEagle : MonoBehaviour
{
    public float speed = 2f;
    public bool isDead = false;
    public Sprite deadEagle;

    private void Update()
    {
        if (StartGame.isStart && isDead == false)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else if (StartGame.isStart && isDead == true)
        {
            GetComponent<CapsuleCollider2D>().isTrigger = true;
            GetComponent<Animator>().enabled = false;
            GetComponent<SpriteRenderer>().flipY = true;
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().sprite = deadEagle;
        }


        if (transform.position.x >= 3f || transform.position.y <= -6f)
            Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isDead = true;
            Destroy(collision.gameObject);
        }
    }
}
