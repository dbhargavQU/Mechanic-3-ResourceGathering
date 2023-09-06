using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;  
    public int numberOfCoins;  

    void Start()
    {
        // Spawn the coins
        for (int i = 0; i < numberOfCoins; i++)
        {
            SpawnCoin();
        }
    }

    // Spawn a single coin at a random position within the camera's view
    void SpawnCoin()
    {
        // Generate random screen coordinates
        float randomX = Random.Range(0, Screen.width);
        float randomY = Random.Range(0, Screen.height);

        // Convert screen coordinates to world coordinates
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(new Vector3(randomX, randomY, Camera.main.farClipPlane / 2));

        // Instantiate the coin
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
