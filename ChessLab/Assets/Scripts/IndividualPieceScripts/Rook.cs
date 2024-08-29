using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the knights moves.
        List<Vector3> rookMoves = new List<Vector3>();

        // Set the start position, which is the piece's current position.
        Vector3 moveStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        // Set move line ends.
        Vector3 moveOneEnd = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x, transform.position.y - 8, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 8, transform.position.y, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 8, transform.position.y, transform.position.z);

        // Add the start and end point of the line to the rookMoves list.
        rookMoves.Add(moveStart);
        rookMoves.Add(moveOneEnd);
        rookMoves.Add(moveStart);
        rookMoves.Add(moveTwoEnd);
        rookMoves.Add(moveStart);
        rookMoves.Add(moveThreeEnd);
        rookMoves.Add(moveStart);
        rookMoves.Add(moveFourEnd);

        // Return the list which is used to draw the gizmo lines for possible moves.
        return rookMoves;
    }
}
