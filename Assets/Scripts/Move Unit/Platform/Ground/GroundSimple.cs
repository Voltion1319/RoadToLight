using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSimple : PlatformMain
{
    public float currentMoveSpeed;
    private void Update()
    {
        MoveDown(currentMoveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
            currentMoveSpeed = 10f;
        if (collision.tag == "Break Point")
            Break();
    }
}
