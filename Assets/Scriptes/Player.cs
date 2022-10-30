using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject player;

    private float speed = 8f;
    public Vector3 direction;

    private void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        transform.position += direction;
    }
}
