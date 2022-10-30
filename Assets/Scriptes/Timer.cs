using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private int second = 1;
    [SerializeField] private int minute = 1;
    [SerializeField] private GameUI gameUI;
    Game gameInstance;

    public int Second { get => second; }
    public int Minute { get => minute; }

    void Start()
    {
        gameInstance = Game.Instance;
        StartCoroutine(StartTimer());
        gameUI.UpadateTimerText(Minute, 0);
    }

    IEnumerator StartTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            second--;
            gameUI.UpadateTimerText(Minute, Second);

            if (second <= 0)
            {
                if (minute > 0)
                {
                    minute--;
                    second = 60;
                }
                else break;
            }
        }
        gameInstance.GameOver("Время вышло!");
    }
}
