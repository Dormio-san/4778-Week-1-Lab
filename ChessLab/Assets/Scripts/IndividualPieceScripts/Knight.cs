using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the knights moves.
        List<Vector3> knightMoves = new List<Vector3>();

        // Set the start position, which is the piece's current position.
        Vector3 moveStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        // Set the end position for each move.
        Vector3 moveOneEnd = new Vector3(transform.position.x - 1, transform.position.y + 2, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveTwoEnd = new Vector3(transform.position.x + 1, transform.position.y + 2, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 2, transform.position.y + 1, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveFourEnd = new Vector3(transform.position.x - 2, transform.position.y + 1, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveFiveEnd = new Vector3(transform.position.x - 1, transform.position.y - 2, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveSixEnd = new Vector3(transform.position.x + 1, transform.position.y - 2, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveSevenEnd = new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveEightEnd = new Vector3(transform.position.x - 2, transform.position.y - 1, transform.position.z);

        // Add the start and end point of the lines to the knightMoves list.
        // The start position is always the current position of the piece, so it can just be added multiple times.
        knightMoves.Add(moveStart);
        knightMoves.Add(moveOneEnd);
        knightMoves.Add(moveStart);
        knightMoves.Add(moveTwoEnd);
        knightMoves.Add(moveStart);
        knightMoves.Add(moveThreeEnd);
        knightMoves.Add(moveStart);
        knightMoves.Add(moveFourEnd);
        knightMoves.Add(moveStart);
        knightMoves.Add(moveFiveEnd);
        knightMoves.Add(moveStart);
        knightMoves.Add(moveSixEnd);
        knightMoves.Add(moveStart);
        knightMoves.Add(moveSevenEnd);
        knightMoves.Add(moveStart);
        knightMoves.Add(moveEightEnd);

        // Return the list which is used to draw the gizmo lines for possible moves.
        return knightMoves;
    }
}
