using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to handle all Inputs made by the player
// Player requires the PlayerData, PlayerMover, and the InputController script

public class InputController : MonoBehaviour
{

    public PlayerData playerData;
    public Vector3 moveDirection;
    private float horizontal;
    private float vertical;

    void Awake()
    {
        playerData = GameObject.FindWithTag("Player").GetComponent<PlayerData>();


    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            moveDirection = new Vector3(horizontal, 0f, vertical) * playerData.sprintSpeed * Time.deltaTime;
            playerData.anim.SetBool("isSprinting", true);
        }
        else
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            moveDirection = new Vector3(horizontal, 0f, vertical) * playerData.moveSpeed * Time.deltaTime;
            playerData.anim.SetBool("isSprinting", false);
        }

        if (moveDirection.x > 0 || moveDirection.z > 0)
        {
            playerData.anim.SetBool("isWalking", true);
        }
        else
        {
            playerData.anim.SetBool("isWalking", false);
        }

        playerData.mover.Move(moveDirection);
    }
}

