using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameManager gm;
    public int thisId;

    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("cursor"))
        {
            gm.regionId = thisId;
        }
    }
}
