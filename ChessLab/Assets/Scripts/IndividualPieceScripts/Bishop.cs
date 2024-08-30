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

        // Set move line ends. The bishop can move in a cross (x) pattern.
        // This means the bishop can move in the northeast, southeast, southwest, and northwest directions.
        // The bishop can move as far as the board allows, so that is 8 units in the four directions above.
        // This chess.com article explains all moves a piece can make well: https://www.chess.com/terms/chess-pieces.
        Vector3 moveOneEnd = new Vector3(transform.position.x + 8, transform.position.y + 8, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x - 8, transform.position.y - 8, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 8, transform.position.y - 8, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 8, transform.position.y + 8, transform.position.z);

        // Add the start and end point of the line to the bishopMoves list.
        // Since the start of each line will always be the piece's current position, add it for each line end coordinate.
        // It is added for each line end coordinate because DrawLineList requires a start and end coordinate for each line.
        bishopMoves.Add(moveStart);
        bishopMoves.Add(moveOneEnd);
        bishopMoves.Add(moveStart);
        bishopMoves.Add(moveTwoEnd);
        bishopMoves.Add(moveStart);
        bishopMoves.Add(moveThreeEnd);
        bishopMoves.Add(moveStart);
        bishopMoves.Add(moveFourEnd);

        // Return the list which is then stored in the Possible moves list and used by the parent class to draw the gizmo lines for possible moves.
        return bishopMoves;
    }
}
