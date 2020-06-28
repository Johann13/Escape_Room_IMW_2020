using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMainMenu : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(LoadGame);
    }

    void LoadGame()
    {
        StartCoroutine(
            LoadLevel(0));
    }

    IEnumerator LoadLevel(int index)
    {
        if (transition != null)
        {
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);
        }

        SceneManager.LoadScene(index);
    }
}