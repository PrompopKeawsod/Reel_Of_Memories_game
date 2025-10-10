using UnityEngine;
using UnityEngine.UI;

public class KeyboardClickButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public KeyCode activationKey;
    private Button button; 

    void Start()
    {
        // Get the Button component attached to this GameObject
        button = GetComponent<Button>();
        if (button == null)
        {
            Debug.LogError("Button component not found on this GameObject!");
            enabled = false; // Disable the script if no button is found
        }
    }

    void Update()
    {
        // Check if the specified key is pressed down
        if (Input.GetKeyDown(activationKey))
        {
            // If the key is pressed, programmatically click the button
            // This triggers the button's OnClick event
            button.onClick.Invoke();
        }
    }
}
