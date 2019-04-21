using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int numberOfActionsPerTurn;
    public bool hasActions;

    public GameObject board;
    public GameObject hand;
    public GameObject outOfBounds;
    Ray2D ray;
    RaycastHit2D hit;
    Vector3 mousePos;

    public int regionId;

    void Start()
    {
        hasActions = true;
        numberOfActionsPerTurn = 2;
    }

    void Update()
    {
        CursorPos();
        if (numberOfActionsPerTurn == 0)
        {
            hasActions = false;
        }
    }

    void CursorPos()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        this.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
    }
}
