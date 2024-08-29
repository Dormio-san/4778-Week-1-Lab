using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pawn : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the pawns moves.
        List<Vector3> pawnMoves = new List<Vector3>();
        
        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 forwardMoveStart = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        Vector3 forwardMoveEnd = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        
        // Add the start and end point of the line to the pawnMoves list.
        pawnMoves.Add(forwardMoveStart);
        pawnMoves.Add(forwardMoveEnd);

        // Return the list which is used to draw the gizmo lines for possible moves.
        return pawnMoves;
    }
}