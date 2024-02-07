using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public AudioSource coinFX;
    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CoinCollectCotroller.coinsCount += 1;
        gameObject.SetActive(false);
    }
}
