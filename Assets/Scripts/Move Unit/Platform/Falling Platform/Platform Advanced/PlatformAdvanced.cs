using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAdvanced : FallingPlatform
{
    private void Start()
    {
        currentMoveSpeed = startChargeSpeed;
    }
    private void Update()
    {
        MoveDown(currentMoveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CalculateStatusTriger(collision);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        CalculateStatusCollision(collision.collider);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && CompareStatus(PlatformStatus.Grounded))
        {
            status = PlatformStatus.Jumping;
            Game.PlayerAssistant(0, false);
            currentMoveSpeed = chargeSpeed;
        }
    }
    private void CalculateStatusTriger(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (status == PlatformStatus.Untouched)
                status = PlatformStatus.Landing;
        }
        else if (collision.CompareTag("Platform Spawner") && CompareStatus(PlatformStatus.Untouched))
            currentMoveSpeed = 0;
        else if (collision.CompareTag("Platform Spawner"))
        {
            currentMoveSpeed = slowSpeed;
            Game.PlayerAssistant(slowSpeed, true);
        }
        else if (collision.CompareTag("Break Point"))
            Break();
    }
    private void CalculateStatusCollision(Collider2D collision)
    {
        if (CompareStatus(PlatformStatus.Landing))
        {
            status = PlatformStatus.Grounded;
            currentMoveSpeed = chargeSpeed;
            Game.PlayerAssistant(chargeSpeed, false);
        }
        else if (CompareStatus(PlatformStatus.Jumping))
        {
            status = PlatformStatus.Wasted;
            currentMoveSpeed = chargeSpeed;
        }
    }
    
}