using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    public GameObject defeat_panel;
    public TMP_Text score_text;
    int score = 0;

    private void Start() => scoreUpdate();

    public void Increase(int points)
    {
        score += points;
        scoreUpdate();
    }
    public void Decrease(int points)
    {
        score -= points;
        scoreUpdate();
    }
    public void scoreUpdate()
    {
        defeat_panel.SetActive(false);
        

        if (score < 0)
        {
            Time.timeScale = 0;
            defeat_panel.SetActive(true);
            score = 0;
        }
        score_text.text = "Score: " + score.ToString();
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
