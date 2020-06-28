using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Remaining Seconds
    public float remainingTime = 60;
    public Text timeText;
    public Text msgText;

    //Puzzle 1
    public bool hasDoorKey = false;

    //Puzzle 2
    public bool hasLaptop = false;

    //Increase time
    public bool pickedUpPhone = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        timeText.text = TimeString();
        msgText.text = "";
        ShowInitText();
    }

    void Update()
    {
        remainingTime -= Time.deltaTime;
        timeText.text = TimeString();
        if (remainingTime <= 0)
        {
            SceneManager.LoadScene(2);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            hasDoorKey = !hasDoorKey;
        }
    }

    string TimeString()
    {
        float min = Mathf.Floor(remainingTime / 60);
        float sec = Mathf.Floor(remainingTime % 60);
        return TwoDigits(min) + ":" + TwoDigits(sec);
    }

    string TwoDigits(float f)
    {
        if (f > 10)
        {
            return "" + f;
        }

        return "0" + f;
    }

    public void AddTime(float seconds)
    {
        this.remainingTime += seconds;
    }


    IEnumerator ShowInitText()
    {
        msgText.text = "You just woke up and need to go to an job interview. " +
                       "But last night you drunkenly shut yourself of and hide the key. " +
                       "You need to find the key. " +
                       "You only have 10 Minutes!";

        msgText.enabled = true;
        yield return new WaitForSeconds(10);
        msgText.text = "";
    }
}