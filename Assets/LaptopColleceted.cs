using UnityEngine;

public class LaptopColleceted : MonoBehaviour
{
    public GameManager GameManager;
    
    void Update()
    {
        if (!GameManager.hasDoorKey)
        {
            return;
        }

        float distance = Vector3.Distance(Camera.main.transform.position,
            transform.position);

        if (distance <= 2 && !GameManager.hasLaptop)
        {
            GameManager.msgText.text = "Click to collect your Laptop";
            if (Input.GetMouseButtonDown(0))
            {
                GameManager.hasLaptop = true;
                Destroy(gameObject);
                GameManager.msgText.text = "";
            }
        }
    }
}