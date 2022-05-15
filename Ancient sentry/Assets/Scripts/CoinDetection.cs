using UnityEngine;

public class CoinDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Friend"))
        {
            //Debug.Log("detected");
            if (collision.transform.position.x > 0)
            {
                transform.position = transform.position - new Vector3(1.5f, 0, 0);
                Debug.Log("moved>1");
            }
            if (collision.transform.position.x < 0)
            {
                transform.position = transform.position + new Vector3(1.5f, 0, 0);
                Debug.Log("moved<1");
            }
        }
    }
}
