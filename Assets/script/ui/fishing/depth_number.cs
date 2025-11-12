using TMPro;
using UnityEngine;

public class depth_number : MonoBehaviour
{
    LineDrawer hook_line;
    hook_movement hook;

    TextMeshProUGUI depth;
    TextMeshProUGUI length;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hook_line = GameObject.Find("hook_obj").GetComponent<LineDrawer>();
        hook = GameObject.Find("hook_obj").GetComponent<hook_movement>();

        depth = transform.Find("depth_num").gameObject.GetComponent<TextMeshProUGUI>();
        length = transform.Find("length_num").gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        float dep = hook_line.get_depth();
        float len = hook_line.get_distance();

        depth.SetText($"{(dep * 0.5) - 2.3:F1}m");
        length.SetText($"{len * 0.5:F1}/{hook.get_hookLength()}m");
    }
}
