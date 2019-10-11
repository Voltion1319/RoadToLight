using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSimple : PlatformMain
{
    private void Update()
    {
        MoveDown(currentMoveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
            currentMoveSpeed = 10f;
        if (collision.CompareTag("Break Point"))
            Break();
    }
}
