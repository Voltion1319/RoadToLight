using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveUnit : MonoBehaviour
{
    protected float chargeSpeed = 4f;
    protected float startChargeSpeed = 7f;
    protected float slowSpeed = 0.3f;

    protected void Move(float speed)
    {
        Vector2 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
    }
    protected void MoveDown(float speed)
    {
        Move(-speed);
    }

}
