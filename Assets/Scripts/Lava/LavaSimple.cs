using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaSimple : LavaMain
{
    public float currentMoveSpeed;
    // Start is called before the first frame update
    private void Start()
    {
        currentMoveSpeed = slowSpeed;
    }
    void Update()
    {
        Move(currentMoveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Lava Stop Point")
            currentMoveSpeed = 0;
    }
}
