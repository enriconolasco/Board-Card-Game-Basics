using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinStack : MonoBehaviour
{
    public GameObject coin;
    public GameManager gm;

    void OnMouseDown()
    {
        if (gm.hasActions)
        {
            Instantiate(coin, new Vector3(transform.position.x - 7f, transform.position.y, transform.position.z), Quaternion.identity);
            gm.numberOfActionsPerTurn--;
        }
        else
        {
            print("you don't have anymore actions");
        }
    }
}
