using UnityEngine;

public class Coin : MonoBehaviour
{
    private Player player;
    private CoinManager manager;
    private float takingDistance;
    private float sqrTakingDistance;
    private void Start()
    {
        player = Game.Instance.Player;
        manager = Game.Instance.CoinManager;
        takingDistance = player.GetComponentInChildren<Transform>().localScale.x + gameObject.transform.localScale.x;
        sqrTakingDistance = takingDistance * takingDistance;
    }

    private void Update()
    {
        CheckDistanceToPlayer();
    }

    /// <summary>
    /// Метод, строящий вектор от игрока к данному объекту и проверяет дистанцию между ними
    /// </summary>
    void CheckDistanceToPlayer()
    {
        float distance = (player.transform.position - transform.position).sqrMagnitude;
        if (distance <= sqrTakingDistance)
        {
            manager.CollectCoin(this);
        }
    }
}
