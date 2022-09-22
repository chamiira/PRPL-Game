using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessGameController : MonoBehaviour
{
    [SerializeField] private BoardLayout startingBoardLayout;

    // private PieceCreator pieceCreator;
    private void Start()
    {
        StartNewGame();
    }
    private void StartNewGame()
    {
        CreatePiecesFromLayout(startingBoardLayout);
    }

    private void CreatePiecesFromLayout(BoardLayout layout)
    {
        for (int i = 0; i < layout.GetPiecesCount(); i++)
        {
            Vector2Int squareCoords = layout.GetSquareCoordsAtIndex(i);
            string typeName = layout.GetSquarePieceNameAtIndex(i);

            Type type = Type.GetType(typeName);
            //CreatePieceAndInitialize(squareCoords, type);
        }
    }

    /* private void CreatePieceAndInitialize(Vector2Int squareCoords, Type type)
    {
        //Piece newPiece = piecesCreator
    }*/
}
