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

        // Set move line ends. The knight's moves are somewhat hard to explain, but it is essentially two away in the vertical and horizontal directions,
        // then one square to the side of that position. So, up 2 units, then 1 unit to the left and right is two potential moves.
        // If you move two units away from the night in the up, down, left, and right directions, then move one unit to each side of that point,
        // you get the total of eight moves possible for the night.
        // This chess.com article explains all moves a piece can make well: https://www.chess.com/terms/chess-pieces.
        Vector3 moveOneEnd = new Vector3(transform.position.x - 1, transform.position.y + 2, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x + 1, transform.position.y + 2, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 2, transform.position.y + 1, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 2, transform.position.y + 1, transform.position.z);
        Vector3 moveFiveEnd = new Vector3(transform.position.x - 1, transform.position.y - 2, transform.position.z);
        Vector3 moveSixEnd = new Vector3(transform.position.x + 1, transform.position.y - 2, transform.position.z);
        Vector3 moveSevenEnd = new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z);
        Vector3 moveEightEnd = new Vector3(transform.position.x - 2, transform.position.y - 1, transform.position.z);

        // Add the start and end point of the line to the knightMoves list.
        // Since the start of each line will always be the piece's current position, add it for each line end coordinate.
        // It is added for each line end coordinate because DrawLineList requires a start and end coordinate for each line.
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

        // Return the list which is then stored in the Possible moves list and used by the parent class to draw the gizmo lines for possible moves.
        return knightMoves;
    }
}
