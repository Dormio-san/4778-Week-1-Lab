using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the knights moves.
        List<Vector3> knightMoves = new List<Vector3>();

        // Set the start position and end position of move one.
        Vector3 moveOneStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 moveOneEnd = new Vector3(transform.position.x - 1, transform.position.y + 2, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveTwoStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x + 1, transform.position.y + 2, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveThreeStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 2, transform.position.y + 1, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveFourStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 2, transform.position.y + 1, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveFiveStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 moveFiveEnd = new Vector3(transform.position.x - 1, transform.position.y - 2, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveSixStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 moveSixEnd = new Vector3(transform.position.x + 1, transform.position.y - 2, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveSevenStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 moveSevenEnd = new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z);

        // Set the start position and end position of the line. The end is + 1 on the Y as pawns can only move one space.
        Vector3 moveEightStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 moveEightEnd = new Vector3(transform.position.x - 2, transform.position.y - 1, transform.position.z);

        // Add the start and end point of the lines to the knightMoves list.
        knightMoves.Add(moveOneStart);
        knightMoves.Add(moveOneEnd);
        knightMoves.Add(moveTwoStart);
        knightMoves.Add(moveTwoEnd);
        knightMoves.Add(moveThreeStart);
        knightMoves.Add(moveThreeEnd);
        knightMoves.Add(moveFourStart);
        knightMoves.Add(moveFourEnd);
        knightMoves.Add(moveFiveStart);
        knightMoves.Add(moveFiveEnd);
        knightMoves.Add(moveSixStart);
        knightMoves.Add(moveSixEnd);
        knightMoves.Add(moveSevenStart);
        knightMoves.Add(moveSevenEnd);
        knightMoves.Add(moveEightStart);
        knightMoves.Add(moveEightEnd);

        // Return the list which is used to draw the gizmo lines for possible moves.
        return knightMoves;
    }
}
