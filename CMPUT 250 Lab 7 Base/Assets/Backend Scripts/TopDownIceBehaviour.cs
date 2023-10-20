﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownIceBehaviour : MonoBehaviour
{
    // the player
    private Rigidbody2D player;
    private TopDownPlayerBehaviour playerScript;

    // Start is called before the first frame update
    void Start()
    {
        player = (Rigidbody2D)GameObject.Find("Player").GetComponent("Rigidbody2D");
        playerScript = (TopDownPlayerBehaviour)player.gameObject.GetComponent(typeof(TopDownPlayerBehaviour));
    }

    // Update is called once per frame
    void Update()
    {
        playerScript.updateIce(transform.position);
    }
}
