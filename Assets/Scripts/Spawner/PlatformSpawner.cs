using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformSpawner : SpawnerMain
{
    public GameObject platformPrefab;
    public BoxCollider2D topColl;
    public float topBorder, botBorder; //boders for next platform's stop point 

    public override void Work()
    {
        GenerateStopCollider();
        Spawn(platformPrefab, transform.position);
    }
    /// <summary>
    /// calculate random position for next platform's stop point
    /// </summary>
    private void GenerateStopCollider()
    {
        var pos = topColl.offset;
        pos.y = Random.Range(botBorder, topBorder);
        topColl.offset = pos;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        topColl.enabled = !topColl.enabled;
        if(topColl.enabled)
            Work();            
    }
}
