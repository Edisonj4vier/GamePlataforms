using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinCollectCotroller : MonoBehaviour
{
    public static int coinsCount;
    public GameObject CoinCountDisplay;
    public GameObject coinEndDisplay;
    
    
    void Update()
    {
        CoinCountDisplay.GetComponent<Text>().text = "" + coinsCount;
        coinEndDisplay.GetComponent<Text>().text = "" + coinsCount;
    }
}
