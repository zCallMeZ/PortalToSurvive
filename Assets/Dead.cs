﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    [SerializeField] Transform waitingPoint;
    [SerializeField] Transform spawnPlayer;

    [SerializeField] GameObject player;

    //public AudioSource bulletSound;

    private bool isDead = false;
    private bool launchTimer = false;

    private float timeStart = 0f;
    private float time = 0f;
    private float timeEnd = 5f;
   

    private void Start()
    {
        time = timeStart;
    }

    private void Update()
    {

        if (launchTimer)
        {
            time += Time.deltaTime;
        }

        if (time >= timeEnd)
        {
            launchTimer = false;
            time = timeStart;
            transform.position = spawnPlayer.position;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zombie")
        {
            launchTimer = true;
            transform.position = waitingPoint.position;
        }
    }
}