using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlatformMain : MoveUnit
{
    protected float currentMoveSpeed;
    protected void Break()
    {
        Destroy(gameObject);
    }
}
