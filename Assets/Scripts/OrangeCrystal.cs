﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCrystal : MonoBehaviour
{

   // public AudioSource som2;
  //  public AudioClip soundCoin;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            LevelManager.levelManager.SetOrangeCrystal();

            //som2.PlayOneShot(soundCoin);
        }
        if (other.CompareTag("Player2"))
        {
            gameObject.SetActive(false);
            LevelManager.levelManager.SetOrangeCrystal();

            //som2.PlayOneShot(soundCoin);
        }

    }
}