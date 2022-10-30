using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Player target;

    private void Start()
    {
        target = Game.Instance.Player;
        gameObject.transform.SetParent(target.transform, false);
    }
}
