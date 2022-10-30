using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text timeText;

    public void UpdateScoreText(int score)
    {
        scoreText.text = $"Собрано монет: {score}";
    }

    public void UpadateTimerText(int minute, int second)
    {
        timeText.text = $"Таймер: {string.Format("{0:00}", minute)}:{string.Format("{0:00}", second)}";
    }
}
