﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCageLevel2 : MonoBehaviour
{
    [SerializeField] GameObject zombieSprite;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "redCage")
        {
            Destroy(gameObject);
            CheckWin2.CheckRed();
            zombieSprite.SetActive(true);
        }
    }
}
