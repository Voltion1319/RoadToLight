using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlatformStatus
{
    Untouched,
    Landing,
    Grounded,
    Jumping,
    Wasted
}

public class PlatformAdvanced : PlatformMain
{
    private float currentMoveSpeed;
    public PlatformStatus status = PlatformStatus.Untouched;

    private void Start()
    {
        currentMoveSpeed = chargeSpeed;
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
    private void CalculateStatusTriger(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (status == PlatformStatus.Untouched)
                status = PlatformStatus.Landing;
            else if (status == PlatformStatus.Grounded)
            {
                status = PlatformStatus.Jumping;
                Game.globalSpeed = 0;
                Game.jumpOn = false;
                currentMoveSpeed = chargeSpeed;
            }               
        }
        else if (collision.tag == "Platform Spawner" && status == PlatformStatus.Untouched)
            currentMoveSpeed = 0;
        else if (collision.tag == "Platform Spawner")
        {
            currentMoveSpeed = slowSpeed;
            Game.globalSpeed = slowSpeed;
            Game.jumpOn = true;
        }   
        else if (collision.tag == "Break Point")
            Break();
    }
    private void CalculateStatusCollision(Collider2D collision)
    {
        if (status == PlatformStatus.Landing)
        {
            status = PlatformStatus.Grounded;
            currentMoveSpeed = chargeSpeed;
            Game.globalSpeed = chargeSpeed;
            Game.jumpOn = false;
        }           
        else if (status == PlatformStatus.Jumping)
        {
            status = PlatformStatus.Wasted;
            currentMoveSpeed = chargeSpeed;
        }
    }
}
