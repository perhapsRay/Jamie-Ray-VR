using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;  // public if you want to drag your text object in there manually
    public static int scoreCounter = 0;

    void Start()
    {
        scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts
    }

    void Update()
    {
        scoreText.text = scoreCounter.ToString();  // make it a string to output to the Text object
    }
}
