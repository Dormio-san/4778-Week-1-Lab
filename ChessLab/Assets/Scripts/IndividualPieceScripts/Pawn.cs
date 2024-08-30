using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pawn : ChessPiece
{
    public override List<Vector3> PossibleMoves(Vector3 currentPosition)
    {
        // Create a new list to store the pawn's moves.
        List<Vector3> pawnMoves = new List<Vector3>();

        // Set the start position, which is the piece's current position.
        Vector3 moveStart = new Vector3 (transform.position.x, transform.position.y, transform.position.z);

        // On the pawn's first move, it can move 2 spaces or 1 space, so the first two moves have a slight x offset to see the two possibilities.
        Vector3 moveOneStart = new Vector3 (transform.position.x + 0.05f, transform.position.y, transform.position.z);
        Vector3 moveTwoStart = new Vector3 (transform.position.x - 0.05f, transform.position.y, transform.position.z);

        // On the pawn's first move, it can move 2 spaces or 1 space, so the first two moves have a slight x offset to see the two possibilities.
        // When capturing an enemy piece, pawns can only capture diagonally, so the third and fourth move end is diagonal.
        // This chess.com article explains all moves a piece can make well: https://www.chess.com/terms/chess-pieces.
        // Additionally, this YouTube video from chess.com explains it more: https://youtu.be/00uUlbcPz5E?si=pRTgYYQeN8sWa5VG.
        Vector3 moveOneEnd = new Vector3(transform.position.x + 0.05f, transform.position.y + 1, transform.position.z);
        Vector3 moveTwoEnd = new Vector3(transform.position.x - 0.05f, transform.position.y + 2, transform.position.z);
        Vector3 moveThreeEnd = new Vector3(transform.position.x + 1, transform.position.y + 1, transform.position.z);
        Vector3 moveFourEnd = new Vector3(transform.position.x - 1, transform.position.y + 1, transform.position.z);

        // Add the start and end point of the line to the pawnMoves list.
        // Since the start of each line will always be the piece's current position, add it for each line end coordinate.
        // The first and second move use a slightly offset starting position so the two lines can be seen.
        // It is added for each line end coordinate because DrawLineList requires a start and end coordinate for each line.
        pawnMoves.Add(moveOneStart);
        pawnMoves.Add(moveOneEnd);
        pawnMoves.Add(moveTwoStart);
        pawnMoves.Add(moveTwoEnd);
        pawnMoves.Add(moveStart);
        pawnMoves.Add(moveThreeEnd);
        pawnMoves.Add(moveStart);
        pawnMoves.Add(moveFourEnd);

        // Return the list which is then stored in the Possible moves list and used by the parent class to draw the gizmo lines for possible moves.
        return pawnMoves;
    }
}