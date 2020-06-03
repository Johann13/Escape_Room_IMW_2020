using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Remaining Seconds
    public float timeStart = 60;
    public Text text;
    public Text loseText;

    void Start()
    {
        text.text = TimeString();
        loseText.text = "";
    }

    void Update()
    {
        timeStart -= Time.deltaTime;
        text.text = TimeString();
        if (timeStart <= 0)
        {
            loseText.text = "Du hast verloren!";
            text.text = "";
        }
    }

    string TimeString()
    {
        float min = Mathf.Floor(timeStart / 60);
        float sec = Mathf.Floor(timeStart % 60);
        return TwoDigits(min) + ":" + TwoDigits(sec);
    }

    string TwoDigits(float f)
    {
        if (f > 10)
        {
            return "" + f;
        }
        else
        {
            return "0" + f;
        }
    }
}