using UnityEngine;

/// <summary>
/// Класс, описывающий сущность препятствия в виде прямоугольника или квадрата
/// </summary>
public class PhysicalObject : MonoBehaviour
{
    private GamePhysics physics;
    private float weight;
    private float lenght;

    public float Weight { get => weight; }
    public float Lenght { get => lenght; }

    void Start()
    {
        if (gameObject.transform.rotation == Quaternion.identity)
        {
            lenght = gameObject.transform.localScale.y;
            weight = gameObject.transform.localScale.x;
        }
        else
        {
            lenght = gameObject.transform.localScale.x;
            weight = gameObject.transform.localScale.y;
        }

        physics = Game.Instance.gamePhysics;
        physics.AddPhysicalObject(this);
    }
}
