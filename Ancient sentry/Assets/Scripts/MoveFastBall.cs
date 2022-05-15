using UnityEngine;

public class MoveFastBall : MonoBehaviour
{
    public float speed = 8f;


    private void Update()
    {
        if (StartGame.isStart)
            transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y <= -6f)
            Destroy(gameObject);

        short score = GameObject.FindGameObjectWithTag("Player").GetComponent<SetScore>().score;

        if (score >= 10)
            speed = 8.5f;
        if (score >= 20)
            speed = 9f;
        if (score >= 30)
            speed = 9.5f;
        if (score >= 40)
            speed = 10f;
        if (score >= 50)
            speed = 10.5f;
        if (score >= 60)
            speed = 11f;
        if (score >= 70)
            speed = 11.5f;
        if (score >= 80)
            speed = 12f;
        if (score >= 90)
            speed = 12.5f;
        if (score >= 100)
            speed = 13f;
        if (score >= 110)
            speed = 13.5f;
        if (score >= 120)
            speed = 14f;
    }
}
