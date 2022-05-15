using UnityEngine;
using System.Collections;

public class CreateBall : MonoBehaviour
{
    public AudioSource source;
    public AudioClip audioEagleScreaming;
    private float waitTime;
    public GameObject ball, fastBall, goodBall, eagle;
    private bool isSpawn;
    private Coroutine spawnB, spawnG, spawnF, spawnE;

    private void Update()
    {
       
        if (StartGame.isStart && !isSpawn)
        {
            spawnB = StartCoroutine(spawnBalls());
            spawnG = StartCoroutine(spawnGoodBalls());
            spawnF = StartCoroutine(spawnFastBalls());
            spawnE = StartCoroutine(spawnEagles());

            isSpawn = true;
        }

    }
    IEnumerator spawnBalls()
    {
        while(true)
        {
            waitTime = Random.Range(0.7f, 1.5f);
            yield return new WaitForSeconds(waitTime);
            if (StartGame.isStart)
            {
                Instantiate(ball, new Vector2(Random.Range(-1.8f, 1.8f), 6f), Quaternion.identity);              
            }
            else
            {
                StopCoroutine(spawnB);
            }
            
        }
    }

    IEnumerator spawnGoodBalls()
    {
        while (true)
        {
            waitTime = Random.Range(0.5f, 1.7f);
            yield return new WaitForSeconds(waitTime);
            if (StartGame.isStart)
            {  
                Instantiate(goodBall, new Vector2(Random.Range(-1.85f, 1.85f), 6f), Quaternion.identity);
            }
            else
            {
                StopCoroutine(spawnG);
            }
            
        }
    }

    IEnumerator spawnFastBalls()
    {
        while (true)
        {
            waitTime = Random.Range(1f, 3f);
            yield return new WaitForSeconds(waitTime);
            if (StartGame.isStart)
            {
                Instantiate(fastBall, new Vector2(Random.Range(-2f, 2f), 6f), Quaternion.identity);
            }
            else
            {
                StopCoroutine(spawnF);
            }
            
        }
    }

    IEnumerator spawnEagles()
    {
        while (true)
        {
            waitTime = Random.Range(20f, 40f);
            yield return new WaitForSeconds(waitTime);
            if (StartGame.isStart)
            {
                Instantiate(eagle, new Vector2(-3, Random.Range(-1f, 4f)), Quaternion.identity);
                source.PlayOneShot(audioEagleScreaming);

            }
            else
            {
                StopCoroutine(spawnE);
            }
           
        }
    }
}
