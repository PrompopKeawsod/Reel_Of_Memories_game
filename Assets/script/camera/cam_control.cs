using UnityEngine;

public class cam_control : MonoBehaviour
{
    public GameObject camera_look_at;
    float speed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (camera_look_at != null)
        {
            //this.transform.position = new Vector3(camera_look_at.transform.position.x, camera_look_at.transform.position.y, -1);

            Vector3 tar_pos = new Vector3(camera_look_at.transform.position.x, camera_look_at.transform.position.y, -1);
            this.transform.position = Vector3.MoveTowards(this.transform.position, tar_pos, step);
        }
    }

    public void set_camera(GameObject obj)
    {
        camera_look_at = obj;
    }

    public void set_speed(float new_speed)
    {
        speed = new_speed;
    }
}
