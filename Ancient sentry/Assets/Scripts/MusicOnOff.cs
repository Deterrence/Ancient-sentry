using UnityEngine;
using UnityEngine.UI;

public class MusicOnOff : MonoBehaviour
{
    public AudioListener source;
    public Sprite musicOn, musicOff;
    private Image button;

    private void Awake()
    {
        button = GetComponent<Image>();
        if (PlayerPrefs.GetString("music") == "off")
        {
            button.sprite = musicOff;
            source.enabled = false;
        }
    } 


    public void SetMusic()
    {
        source.enabled = !source.enabled;
         if(source.enabled)
        {
            button.sprite = musicOn;
            PlayerPrefs.SetString("music", "on");
        } else
        {
            button.sprite = musicOff;
            PlayerPrefs.SetString("music", "off");
        }
    }
}
