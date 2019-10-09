using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSimple : PlayerMain
{
    public Rigidbody2D rb;
    public float currentJumpPower;
    public float jumpIndex = 500;

    void FixedUpdate()
    {
        Jump();
    }
    protected override void Jump()
    {
        if ((Input.GetKey(KeyCode.Space) || Input.touchCount >= 1) && Game.jumpOn)
        {
            currentJumpPower += Time.deltaTime * jumpIndex;
        }
        if (Input.GetKey(KeyCode.Space) == false && Input.touchCount < 1  && Game.jumpOn)
        {
            if (currentJumpPower >= 1000)
                currentJumpPower = 1000;
            rb.AddForce(Vector3.up * currentJumpPower);
            currentJumpPower = 0;
        }
    }
    private void Update()
    {
        MoveDown(Game.globalSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Death(collision);
    }
}
