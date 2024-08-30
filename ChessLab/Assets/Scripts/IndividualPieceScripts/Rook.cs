using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the rook's moves.
        List<Vector3> rookMoves = new List<Vector3>();

        // Set the start position, which is the piece's current position.
        Vector3 moveStart = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        // Set move line ends. The rook can move in a plus (+) sign type of pattern for as far as the board allows.
        // Therefore, the possible moves' lines extend to the limit of the board boundaries (8 units) in the left, right, up, and down directions.
        // Or, in compass terms, that is the north, east, south, and west directions.
        // This chess.com article explains all moves a piece can make well: https://www.chess.com/terms/chess-pieces.
        Vector3 moveOneEnd = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x, transform.position.y - 8, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 8, transform.position.y, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 8, transform.position.y, transform.position.z);

        // Add the start and end point of the line to the rookMoves list.
        // Since the start of each line will always be the piece's current position, add it for each line end coordinate.
        // It is added for each line end coordinate because DrawLineList requires a start and end coordinate for each line.
        rookMoves.Add(moveStart);
        rookMoves.Add(moveOneEnd);
        rookMoves.Add(moveStart);
        rookMoves.Add(moveTwoEnd);
        rookMoves.Add(moveStart);
        rookMoves.Add(moveThreeEnd);
        rookMoves.Add(moveStart);
        rookMoves.Add(moveFourEnd);

        // Return the list which is then stored in the Possible moves list and used by the parent class to draw the gizmo lines for possible moves.
        return rookMoves;
    }
}
