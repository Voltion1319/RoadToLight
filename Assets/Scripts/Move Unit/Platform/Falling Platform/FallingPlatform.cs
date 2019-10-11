using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FallingPlatform : PlatformMain
{
    protected enum PlatformStatus
    {
        Untouched,
        Landing,
        Grounded,
        Jumping,
        Wasted
    }

    protected PlatformStatus status = PlatformStatus.Untouched;

    protected bool CompareStatus(PlatformStatus stat)
    {
        return status == stat ? true : false;
    }
}
