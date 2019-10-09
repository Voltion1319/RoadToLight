using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class PlayerMain : MoveUnit
{
    protected abstract void Jump();
    protected void Death(Collider2D collision)
    {
        if (collision.tag == "Lava" || collision.tag == "Stalactites")
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(0);
        }        
    }

}
