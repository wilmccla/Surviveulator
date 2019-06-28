using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Script to control moving the player
// Player requires the PlayerData, PlayerMover, and the InputController script
public class PlayerMover : MonoBehaviour
{

    public PlayerData data;
    void Awake()
    {
        data = GetComponent<PlayerData>();
    }
    public void Move(Vector3 moveDirection)
    {
        transform.Translate(moveDirection, Space.Self);
    }
}