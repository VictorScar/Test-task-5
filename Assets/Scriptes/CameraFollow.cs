using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Player target;

    private void Start()
    {
        target = Game.Instance.Player;
        gameObject.transform.SetParent(target.transform, false);
    }
}
