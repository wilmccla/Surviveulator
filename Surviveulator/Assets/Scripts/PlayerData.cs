using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

// Script to hold any variables other scripts may need to access for the player, also as a place for all other Player scripts to connect to
// Player requires the PlayerData, PlayerMover, and the InputController script

public class PlayerData : MonoBehaviour
{
    //Components
    [Header("Components")]
    public Transform tf;
    public PlayerMover mover;
    public Rigidbody rb;
    public Animator anim;

    //Variables
    [Header("Variables")]
    public float moveSpeed;
    public float sprintSpeed;

    void Awake()
    {
        tf = GetComponent<Transform>();
        mover = GetComponent<PlayerMover>();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
}
