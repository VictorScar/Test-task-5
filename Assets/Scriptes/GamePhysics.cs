using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс, обеспечивающий работу физики препятствий, через которые игрок не может пройти
/// </summary>
public class GamePhysics : MonoBehaviour
{
    Player player;
    [SerializeField] List<PhysicalObject> physicalObjects;

    private void Start()
    {
        player = Game.Instance.Player;
    }

    private void Update()
    {
        foreach (PhysicalObject obj in physicalObjects)
        {
            Vector3 directionToObject = player.transform.position - obj.transform.position;

            if (Mathf.Abs(directionToObject.x) <= obj.Weight / 2 && Mathf.Abs(directionToObject.z) <= obj.Lenght / 2)
            {
                player.transform.position -= player.direction;
            }
        }
    }

    public void AddPhysicalObject(PhysicalObject obj)
    {
        physicalObjects.Add(obj);
    }
}
