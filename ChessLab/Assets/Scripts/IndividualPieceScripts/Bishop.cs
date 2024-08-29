using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the pawns moves.
        List<Vector3> bishopMoves = new List<Vector3>();

        // Set the start position, which is the piece's current position.
        Vector3 moveStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        Vector3 moveOneEnd = new Vector3(transform.position.x + 8, transform.position.y + 8, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x - 8, transform.position.y - 8, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 8, transform.position.y - 8, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 8, transform.position.y + 8, transform.position.z);

        // Add the start and end point of the line to the pawnMoves list.
        bishopMoves.Add(moveStart);
        bishopMoves.Add(moveOneEnd);
        bishopMoves.Add(moveStart);
        bishopMoves.Add(moveTwoEnd);
        bishopMoves.Add(moveStart);
        bishopMoves.Add(moveThreeEnd);
        bishopMoves.Add(moveStart);
        bishopMoves.Add(moveFourEnd);

        // Return the list which is used to draw the gizmo lines for possible moves.
        return bishopMoves;
    }
}
