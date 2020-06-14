using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
    void Start()
    {
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ButtonClick);
    }

    private void ButtonClick()
    {
        SceneManager.LoadScene(0);
    }
}