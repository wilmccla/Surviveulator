using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public PlayerData data;
    public Transform target;

    void Update()
    {
        target.transform.position = new Vector3(data.tf.position.x, data.tf.position.y + 1.7f, data.tf.position.z);
    }
}
