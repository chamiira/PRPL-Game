using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Board/Chessboard Grid")]
public class ChessboardGrid : ScriptableObject
{
    // making each tile a game object that will be stored into a matrix
    [SerializeField] private Vector2 gridSize;
    public GameObject[][] chessboardGrid;
    public void Start()
    {
        chessboardGrid = new GameObject[(int)gridSize.x][];
        for (int x = 0; x <gridSize.x; x++)
        {
            chessboardGrid[x] = new GameObject[(int)gridSize.y];
            for (int y = 0; y < gridSize.y; y++)
            {
                GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                chessboardGrid[x][y] = go;
            }
        }
    }

    public Vector2 GetGridSize()
    {
        return gridSize;
    }

}
