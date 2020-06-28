using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(Quit);
    }

    private void Quit()
    {
        Application.Quit();
    }
}