using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    public GameObject startPoint; // Assign in Inspector
    public GameObject endPoint;   // Assign in Inspector
    private LineRenderer lineRenderer;

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        if (lineRenderer == null)
        {
            Debug.LogError("LineRenderer component not found on this GameObject!");
            enabled = false; // Disable script if no LineRenderer
        }
    }

    void Update()
    {
        if (startPoint != null && endPoint != null)
        {
            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0, startPoint.transform.position);
            lineRenderer.SetPosition(1, endPoint.transform.position);
        }
    }
}
