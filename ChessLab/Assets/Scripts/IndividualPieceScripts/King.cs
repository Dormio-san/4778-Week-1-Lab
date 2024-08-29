using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the pawns moves.
        List<Vector3> kingMoves = new List<Vector3>();

        // Set the start position, which is the piece's current position.
        Vector3 moveStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        Vector3 moveOneEnd = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        Vector3 moveFiveEnd = new Vector3(transform.position.x + 1, transform.position.y + 1, transform.position.z);
        Vector3 moveSixEnd = new Vector3(transform.position.x - 1, transform.position.y - 1, transform.position.z);
        Vector3 moveSevenEnd = new Vector3(transform.position.x -1 , transform.position.y + 1, transform.position.z);
        Vector3 moveEightEnd = new Vector3(transform.position.x + 1, transform.position.y - 1, transform.position.z);

        // Add the start and end point of the line to the pawnMoves list.
        kingMoves.Add(moveStart);
        kingMoves.Add(moveOneEnd);
        kingMoves.Add(moveStart);
        kingMoves.Add(moveTwoEnd);
        kingMoves.Add(moveStart);
        kingMoves.Add(moveThreeEnd);
        kingMoves.Add(moveStart);
        kingMoves.Add(moveFourEnd);
        kingMoves.Add(moveStart);
        kingMoves.Add(moveFiveEnd);
        kingMoves.Add(moveStart);
        kingMoves.Add(moveSixEnd);
        kingMoves.Add(moveStart);
        kingMoves.Add(moveSevenEnd);
        kingMoves.Add(moveStart);
        kingMoves.Add(moveEightEnd);

        // Return the list which is used to draw the gizmo lines for possible moves.
        return kingMoves;
    }
}
