using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public Vector3 targetPos;
    public GameObject player;
    public float speed;

    private void Update()
    {
        if (StartGame.isStart)
        {
#if UNITY_IOS
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                targetPos = Camera.main.ScreenToWorldPoint(touch.position);
              
            }
        }
#endif

#if UNITY_EDITOR
        if(Input.GetMouseButton(0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          
        }
#endif
            float step = speed * Time.deltaTime;
            if (targetPos.x < -1.8f)
            {
                targetPos.x = -1.8f;
            }
            else if (targetPos.x > 1.8f)
            { 
                targetPos.x = 1.8f;
            }
            

            player.transform.position = Vector3.MoveTowards(player.transform.position, new Vector3(targetPos.x, player.transform.position.y, player.transform.position.z), step);
            
           
              
        }

    }

}
