using TMPro;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;

    [SerializeField] TMP_Text headerText;
    [SerializeField] TMP_Text totalScoreText;
    [SerializeField] TMP_Text totalTimeText;
    public void ShowMenuPanel(string mesage, int score, int minutes, int seconds)
    {
        headerText.text = mesage;
        totalScoreText.text = $"Монет собрано: {score}";
        totalTimeText.text = $"Времени осталось: {string.Format("{0:00}", minutes)}:{string.Format("{0:00}", seconds)}";
        menuPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
