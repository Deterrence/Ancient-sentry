using UnityEngine;

public class CreateCloud : MonoBehaviour
{
    public GameObject now_cloud, cloud_inst;
    private GameObject new_cloud;

    private void Update()
    {
        
        
            if (now_cloud.transform.position.x >= 5f && new_cloud == null)
                createNewBg();
            else if (new_cloud != null && new_cloud.transform.position.x >= 5f)
                createNewBg();
        
    }
    void createNewBg()
    {
        if (now_cloud.transform.position.x > 15f)
        {
            Destroy(now_cloud);
            now_cloud = new_cloud;
        }
        new_cloud = Instantiate(cloud_inst, new Vector2(-15f, 0f), Quaternion.identity) as GameObject;
    }
}
