using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenControll : MonoBehaviour
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
            LoadLevel(3));
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