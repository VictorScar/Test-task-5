using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private Coin coinPrefab;
    private Game gameInstance;
    [SerializeField] private GameUI gameUI;

    private float playingFieldWedth;
    private float playingFieldLenght;
    [SerializeField] private List<Coin> collectedCoins;
    [SerializeField] private int coinCount = 10;
    private int collectedCoinCount = 0;

    public int CollectedCoinCount { get => collectedCoinCount; }

    private void Awake()
    {
        gameInstance = Game.Instance;
        playingFieldWedth = gameInstance.PlayingFieldWedth;
        playingFieldLenght = gameInstance.PlayingFieldLenght;
        GeneratCoins();
    }

    void GeneratCoins()
    {
        for (int i = 0; i < coinCount; i++)
        {
            Vector3 coinPosition = new Vector3(Random.Range(-playingFieldLenght, playingFieldLenght),
                0, Random.Range(-playingFieldWedth, playingFieldWedth));
            Instantiate(coinPrefab, coinPosition, Quaternion.identity);
        }
    }

    public void CollectCoin(Coin coin)
    {
        collectedCoins.Add(coin);
        collectedCoinCount++;
        Destroy(coin.gameObject);
        gameUI.UpdateScoreText(collectedCoinCount);

        if (collectedCoins.Count >= coinCount)
        {
            gameInstance.GameOver("Все монеты собраны!");
        }
    }
}
