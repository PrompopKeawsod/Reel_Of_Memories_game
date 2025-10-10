using UnityEngine;

public class hook_movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float push_down_force = 5f;
    man_control man;
    Rigidbody2D m_Rigidbody;

    Vector3 original_location;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        man = GameObject.Find("man_obj").GetComponent<man_control>();
        m_Rigidbody = GetComponent<Rigidbody2D>();
        original_location = transform.position;

        transform.position = new Vector3(999, 999, 999);
    }

    // Update is called once per frame
    void Update()
    {
        if (!man.is_idle)
        {
            float horizontalInput = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow keys
            float verticalInput = Input.GetAxis("Vertical");   // W/S or Up/Down Arrow keys

            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }

    public void start_fishing()
    {
        gameObject.SetActive(true);

        transform.position = original_location;
    }

    public void stop_fishing()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "surface")
        {
            man.stop_fishing();
        }
    }
}
