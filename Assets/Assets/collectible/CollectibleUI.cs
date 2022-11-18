using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleUI : MonoBehaviour
{
    private TextMeshProUGUI coinCount;

    // Start is called before the first frame update
    void Start()
    {
        coinCount = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCoinCount(PlayerStats playerStats)
    {
        coinCount.text = "Collectibles: " + playerStats.coins.ToString();
    }
}
