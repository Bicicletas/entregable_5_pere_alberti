using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(20, 2.5f, 15);

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
