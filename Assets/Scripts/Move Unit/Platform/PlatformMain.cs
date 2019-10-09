using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlatformMain : MoveUnit
{
    protected void Break()
    {
        Destroy(gameObject);
    }
}
