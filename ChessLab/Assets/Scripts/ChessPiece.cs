using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChessPiece : MonoBehaviour
{
    [HideInInspector] public Vector3 piecePosition;
    
    // Stores the color of the chess piece.
    public Color pieceColor = Color.white;

    // Reference to the sprite renderer on the piece.
    private SpriteRenderer spriteRenderer;

    // Whenever a value is changed in the inspector, the sprite renderer component will be got and the color will change to the new piece color.
    private void OnValidate()
    {
        // Get sprite renderer and change its color.
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = pieceColor;
    }

    // Method that can be overridden by derived classes to store the moves they can make.
    public abstract List<Vector3> PossibleMoves(Vector3 currentPosition);

    // When piece is selected, draw gizmos of where they can move.
    private void OnDrawGizmosSelected()
    {
        // Convert the abstract method to a list so it can then be converted to an array that can then be used by DrawLineList.
        List<Vector3> movesList = PossibleMoves(piecePosition);
        Vector3[] moves = movesList.ToArray();

        // Set the color of the gizmo lines to the color of the piece and draw them.
        Gizmos.color = pieceColor;
        Gizmos.DrawLineList(moves);
    }
}
