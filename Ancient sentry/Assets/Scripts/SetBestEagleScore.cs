using UnityEngine;
using UnityEngine.UI;

public class SetBestEagleScore : MonoBehaviour
{
    private Text eagleScoreText;

    private void Awake()
    {
        GetComponent<Text>().text = "Best eagle score: " + PlayerPrefs.GetInt("eagleScore").ToString();
    }
}
