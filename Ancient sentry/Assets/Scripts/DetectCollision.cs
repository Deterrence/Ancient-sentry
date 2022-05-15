using UnityEngine;

public class DetectCollision : MonoBehaviour


{
    public AudioSource source;
    public AudioClip audioLose, audioCollect, audioLeather;
    public Sprite deadHero;
    public GameObject explosion, panelLose;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            source.PlayOneShot(audioLose);
            StartGame.isStart = false;
            Destroy(collision.gameObject);
            GetComponent<SpriteRenderer>().sprite = deadHero;

            ContactPoint2D contact = collision.contacts[0];
            Vector3 pos = contact.point;
            GameObject exp = Instantiate(explosion, pos, Quaternion.identity) as GameObject;
            Destroy(exp, 1f);

            panelLose.SetActive(true); 
        }
       
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Friend"))
        {
            collision.GetComponent<Animation>().Play("HideBall");
            Destroy(collision.gameObject, 0.1f);
            source.PlayOneShot(audioCollect);
        }

        if (collision.gameObject.CompareTag("Eagle"))
        {
            collision.GetComponent<Animation>().Play("HideEagle");
            Destroy(collision.gameObject, 0.1f);
            source.PlayOneShot(audioLeather);
        }
    }
}
