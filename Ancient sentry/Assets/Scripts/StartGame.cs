using UnityEngine;

public class StartGame : MonoBehaviour
{
    public float hideSpeed = 5f;
    public GameObject logoText, scoreText, soundButton, eagleScoreText;
    public static bool isStart;
    private void Update()
    {
        if (isStart && logoText != null)
            logoText.transform.Translate(Vector2.up * hideSpeed * Time.deltaTime);
    }
   public void startGame()
    {
        if (isStart)
            return;
        isStart = true;
        //logoText.GetComponent<Animator>().enabled = false;
        Destroy(logoText, 3f);
        GetComponent<Animation>().Play("HidePlayButton");

        soundButton.SetActive(false);
        scoreText.SetActive(true);
        eagleScoreText.SetActive(false);
    }
}
 