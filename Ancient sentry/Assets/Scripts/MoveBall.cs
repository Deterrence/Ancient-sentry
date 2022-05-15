using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float speed = 4f;
 
    
    private void Update()
    {
        if (StartGame.isStart)
            transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y <= -6f)
            Destroy(gameObject);

        short score = GameObject.FindGameObjectWithTag("Player").GetComponent<SetScore>().score;

        if (score >= 10)
            speed = 4.5f;
        if (score >= 20)
            speed = 5f;
        if (score >= 30)
            speed = 5.5f;
        if (score >= 40)
            speed = 6f;
        if (score >= 50)
            speed = 6.5f;
        if (score >= 60)
            speed = 7f;
        if (score >= 70)
            speed = 7.5f;
        if (score >= 80)
            speed = 8f;
        if (score >= 90)
            speed = 8.5f;
        if (score >= 100)
            speed = 9f;
        if (score >= 110)
            speed = 9.5f;
        if (score >= 120)
            speed = 10f;

    }
}
