using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SRCScoreManager : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
}
