using UnityEngine;

public class CreateBG : MonoBehaviour
{
    public GameObject now_bg, bg_inst;
    private GameObject new_bg; 

    private void Update()
    {
        if (StartGame.isStart)
        {
            if (now_bg.transform.position.y <= -1.5f && new_bg == null )
                createNewBg();
            else if(new_bg != null && new_bg.transform.position.y <= -1.5f) 
                createNewBg();
        }
    }
    void createNewBg()
    {
        if(now_bg.transform.position.y < -15f)
        {
            Destroy(now_bg);
            now_bg = new_bg;
        }
        new_bg = Instantiate(bg_inst, new Vector2(0f, 14.06f), Quaternion.identity) as GameObject;
    }
}
