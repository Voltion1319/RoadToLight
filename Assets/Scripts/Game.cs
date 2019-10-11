using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static int lvl = 0; // number of current lvl
    public static float globalSpeed;
    public static bool jumpOn;
    public BoxCollider2D coll;

    public static void PlayerAssistant(float speed, bool jumpSwitch)
    {
        globalSpeed = speed;
        jumpOn = jumpSwitch;
    }
    private void Awake()
    {
        globalSpeed = 0;
        jumpOn = true;
    }
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
}
