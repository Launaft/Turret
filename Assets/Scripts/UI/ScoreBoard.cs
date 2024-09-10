using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    public GameObject defeat_panel;
    public TMP_Text score_text;

    private void Update() => scoreUpdate();

    public void scoreUpdate()
    {
        defeat_panel.SetActive(false);
        
        if (Score.ScorePoints < 0)
        {
            Time.timeScale = 0;
            defeat_panel.SetActive(true);
            score_text.text = "Score: 0";
        }
        score_text.text = "Score: " + Score.ScorePoints.ToString();
    }
}