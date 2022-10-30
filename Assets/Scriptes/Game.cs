using UnityEngine;

public class Game : MonoBehaviour
{
    [Header("Компоненты")]
    [SerializeField] private GameObject playingField; //Размер игрового поля
    [SerializeField] private Player playerPrefab;
    [SerializeField] public GamePhysics gamePhysics;
    [SerializeField] private CoinManager coinManager;
    [SerializeField] private Timer timer;
    [SerializeField] private MenuPanel menuPanel;

    private float fieldWedth;
    private float fieldLenght;
    private float offset = 1;

    private Player player;

    public static Game Instance { get; private set; }
    public Player Player { get => player; }
    public CoinManager CoinManager { get => coinManager; }
    public float PlayingFieldWedth { get => fieldWedth; }
    public float PlayingFieldLenght { get => fieldLenght; }

    private void Awake()
    {
        fieldLenght = playingField.transform.localScale.z / 2 - offset;
        fieldWedth = playingField.transform.localScale.x / 2 - offset;
        Vector3 playerStartPosition = new Vector3(Random.Range(-fieldLenght, fieldLenght), 0, Random.Range(-fieldWedth, fieldWedth));
        Instance = this;
        player = Instantiate(playerPrefab, playerStartPosition, Quaternion.identity);
    }

    public void GameOver(string message)
    {
        int seconds = timer.Second;
        int minutes = timer.Minute;
        int coinCount = coinManager.CollectedCoinCount;
        menuPanel.ShowMenuPanel(message, coinCount, minutes, seconds);
    }
}
