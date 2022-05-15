using UnityEngine;
using UnityEngine.UI;

public class SetBestScore : MonoBehaviour
{
    private Text scoreText;

    private void Awake()
    {
        GetComponent<Text>().text = "Best score: " + PlayerPrefs.GetInt("score").ToString();
    }
}
