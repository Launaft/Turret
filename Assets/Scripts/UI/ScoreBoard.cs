using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{
    public GameObject defeat_panel;
    public TMP_Text score_text;

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start() => scoreUpdate();

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