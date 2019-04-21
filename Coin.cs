using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : GamePiece
{
    public override void OnMouseUp()
    {
        if (isHoldingPiece == true)
        {
            isHoldingPiece = false;
            canGetPos = true;
            switch (gm.regionId)
            {
                case 0://check if card was put out of bounds
                    transform.position = initialPiecePos;
                    break;
                case 1:
                    print("coinWasPutInHand");
                    break;
            }
        }
    }
}
