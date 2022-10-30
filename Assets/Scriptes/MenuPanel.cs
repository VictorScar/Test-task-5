using TMPro;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;

    [SerializeField] private TMP_Text headerText;
    [SerializeField] private TMP_Text totalScoreText;
    [SerializeField] private TMP_Text totalTimeText;
    public void ShowMenuPanel(string mesage, int score, int minutes, int seconds)
    {
        headerText.text = mesage;
        totalScoreText.text = $"Монет собрано: {score}";
        totalTimeText.text = $"Времени осталось: {string.Format("{0:00}", minutes)}:{string.Format("{0:00}", seconds)}";
        menuPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
