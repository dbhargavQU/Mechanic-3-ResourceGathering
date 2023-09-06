using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  

public class CoinCollector : MonoBehaviour
{
    public TextMeshProUGUI coinText;  
    private int coinCount = 0; 

    void Start()
    {
        UpdateCoinText();  // Initialize coin text
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))  // Check if the object is tagged as Coin
        {
            Destroy(other.gameObject);  // Remove the coin
            coinCount++;  // Increment the counter
            UpdateCoinText();  // Update the UI text
        }
    }

    
    private void UpdateCoinText()
    {
        coinText.text = "Coins: " + coinCount;
    }
}
