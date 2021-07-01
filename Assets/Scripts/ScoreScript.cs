using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    public Text HighScoreText;
    int ScoreNum = 0;
    int Highscore = 0;


    // Start is called before the first frame update
    void Start()
    {
        MyscoreText.text = "Score : " + ScoreNum;

        Highscore = PlayerPrefs.GetInt("highscore", 0);
        HighScoreText.text = "HIGHSCORE: " + Highscore.ToString();


    }

    public void ResetHS()
    {
        PlayerPrefs.SetInt("highscore", 0);
    }


    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "MyCoin")
        {
            ScoreNum += 1;
            MyscoreText.text = "Score : " + ScoreNum;
            if (Highscore < ScoreNum)
            {
                PlayerPrefs.SetInt("highscore", ScoreNum);
            }
            
            
        }

    }

}
