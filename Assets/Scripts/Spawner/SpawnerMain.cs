using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnerMain : MonoBehaviour
{
    public abstract void Work();
    protected GameObject Spawn(GameObject prefab, Vector3 pos)
    {
        return Instantiate(prefab, pos, Quaternion.identity);
    }
}
