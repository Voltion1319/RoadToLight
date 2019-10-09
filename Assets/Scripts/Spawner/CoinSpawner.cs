using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : SpawnerMain
{
    public GameObject coinPrefab;
    public float percentOfCoinSpawn = 90;
    public GameObject currentCoin;

    public override void Work()
    {
        if (currentCoin == null && Random.value * 100 <= percentOfCoinSpawn)
        {
            currentCoin = Spawn(coinPrefab, transform.position);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
            Work();
    }


}
