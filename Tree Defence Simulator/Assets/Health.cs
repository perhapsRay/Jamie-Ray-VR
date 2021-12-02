using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Text healthText;
    public static int healthCounter = 1000;

    void Start()
    {
        healthText = GetComponent<Text>();
    }

    void Update()
    {
        healthText.text = healthCounter.ToString();
    }
}
