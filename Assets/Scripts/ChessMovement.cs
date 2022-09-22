using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessMovement : MonoBehaviour
{
	public ChessboardGrid cg;

	public void MarkNextLegalMoves(GameObject go, string pieceType)
	{
		//clear all previous legal moves
		bool LegalNextMove = false;
		bool CurrentlyOccupied = false;
		Vector2 grid = cg.GetGridSize();
		for (int i = 0; i < grid.x; i++)
		{
			for (int j = 0; j < grid.y; j++)
			{
				/*cg.chessboardGrid[i][j].LegalNextMove = false;
				cg.chessboardGrid[i][j].CurrentlyOccupied = false;*/
			}
		}

		//find all legal moves and mark legal
		switch (pieceType)
		{
			case "Knight":
				break;
			case "King":
				break;
			case "Queen":
				break;
			case "Rook":
				break;
			case "Bishop":
				break;
			case "Pawn":
				break;
		}
	}
}
