using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the pawns moves.
        List<Vector3> queenMoves = new List<Vector3>();

        // Set the start position, which is the piece's current position.
        Vector3 moveStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        Vector3 moveOneEnd = new Vector3(transform.position.x + 8, transform.position.y + 8, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x - 8, transform.position.y - 8, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 8, transform.position.y - 8, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 8, transform.position.y + 8, transform.position.z);
        Vector3 moveFiveEnd = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);
        Vector3 moveSixEnd = new Vector3(transform.position.x, transform.position.y - 8, transform.position.z);
        Vector3 moveSevenEnd = new Vector3(transform.position.x + 8, transform.position.y, transform.position.z);
        Vector3 moveEightEnd = new Vector3(transform.position.x - 8, transform.position.y, transform.position.z);

        // Add the start and end point of the line to the pawnMoves list.
        queenMoves.Add(moveStart);
        queenMoves.Add(moveOneEnd);
        queenMoves.Add(moveStart);
        queenMoves.Add(moveTwoEnd);
        queenMoves.Add(moveStart);
        queenMoves.Add(moveThreeEnd);
        queenMoves.Add(moveStart);
        queenMoves.Add(moveFourEnd);
        queenMoves.Add(moveStart);
        queenMoves.Add(moveFiveEnd);
        queenMoves.Add(moveStart);
        queenMoves.Add(moveSixEnd);
        queenMoves.Add(moveStart);
        queenMoves.Add(moveSevenEnd);
        queenMoves.Add(moveStart);
        queenMoves.Add(moveEightEnd);

        // Return the list which is used to draw the gizmo lines for possible moves.
        return queenMoves;
    }
}
