using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the queen's moves.
        List<Vector3> queenMoves = new List<Vector3>();

        // Set the start position, which is the piece's current position.
        Vector3 moveStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        // Set move line ends. The queen can move like a rook and bishop combined, so the queen can move in both a plus (+) and cross (x) formation.
        // The queen can also move as far as the board allows, so each move goes to the maximum of 8 units.
        // An easy way to think of the queen's movement is as far as the board allows in terms of a compass.
        // This means the queen can move up to 8 units in the north, northeast, east, southeast, south, southwest, west, and northwest directions.
        // This chess.com article explains all moves a piece can make well: https://www.chess.com/terms/chess-pieces.
        Vector3 moveOneEnd = new Vector3(transform.position.x + 8, transform.position.y + 8, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x - 8, transform.position.y - 8, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 8, transform.position.y - 8, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 8, transform.position.y + 8, transform.position.z);
        Vector3 moveFiveEnd = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);
        Vector3 moveSixEnd = new Vector3(transform.position.x, transform.position.y - 8, transform.position.z);
        Vector3 moveSevenEnd = new Vector3(transform.position.x + 8, transform.position.y, transform.position.z);
        Vector3 moveEightEnd = new Vector3(transform.position.x - 8, transform.position.y, transform.position.z);

        // Add the start and end point of the line to the queenMoves list.
        // Since the start of each line will always be the piece's current position, add it for each line end coordinate.
        // It is added for each line end coordinate because DrawLineList requires a start and end coordinate for each line.
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

        // Return the list which is then stored in the Possible moves list and used by the parent class to draw the gizmo lines for possible moves.
        return queenMoves;
    }
}
