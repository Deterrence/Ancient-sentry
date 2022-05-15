using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    public Text scoreText, eagleScoreText;
    public short score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Friend"))
        {
            score++;
            scoreText.text = "×" + score.ToString();

            if(PlayerPrefs.GetInt("score") < score)
                 PlayerPrefs.SetInt("score", score);

        }

        if (collision.gameObject.CompareTag("Eagle"))
        {
            int newEagle = PlayerPrefs.GetInt("eagleScore") + 1;
            PlayerPrefs.SetInt("eagleScore", newEagle);
            
        }

        
    }

    
}
