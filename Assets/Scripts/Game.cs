using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static int lvl = 0; // count current lvl
    public static float globalSpeed;
    public static bool jumpOn;
    public BoxCollider2D coll;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            jumpOn = true;
        else if (collision.tag == "Platform")
            coll.enabled = false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            jumpOn = false;
    }
    private void Awake()
    {
        globalSpeed = 0;
        jumpOn = true;
    }
}
