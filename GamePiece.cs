using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GamePiece : MonoBehaviour
{
    public bool isHoldingPiece;
    public Vector3 mousePos;

    public GameManager gm;

    public Vector3 initialPiecePos;
    public bool canGetPos = true;

    public int currentId = 2; //this prob needs to be switched

    public int fromPlayer;
    enum PlayersIndex
    {
        Player1 = 1,
        Player2 = 2,
        Player3 = 3,
        Player4 = 4
    };

    public virtual void Start()
    {
        if (gm == null)
        {
            gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        isHoldingPiece = false;
    }

    public virtual void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        HoldCard();
    }

    public virtual void HoldCard()
    {
        if (isHoldingPiece)
        {
            gameObject.transform.position = new Vector3(mousePos.x, mousePos.y, 0.0f);
        }
    }

    public virtual void OnMouseDown()
    {
        if (isHoldingPiece == false)
        {
            if (canGetPos)
            {
                initialPiecePos = transform.position;
                canGetPos = false;
            }
            isHoldingPiece = true;
        }
    }

    public abstract void OnMouseUp();
}
