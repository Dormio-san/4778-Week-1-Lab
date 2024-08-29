using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChessBoard : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        // Variables for the width and height of the board to allow for different sizes.
        int width = 8;
        int height = 8;

        // Perform two for loops. One goes along the width (x) with each iteration, while the other fills in the height at said width (x position).
        for (int i = 0; i < width; i ++)
        {
            for (int j = 0; j < height; j++)
            {
                // Boolean that allows us to alternate between white and black squares.
                // To determine the value, add the i and j variables and then divide by 2.
                // If the remainder once the division is finished is 0, then the bool is true. Otherwise it is false.
                // For example, if (i + j) equals 3, 3 goes into 2 once with 1 left over as a remainder.
                // Therefore, the bool would be false and the current square would be white.
                bool isBlackSquare = (i + j) % 2 == 0;

                // Set the color to black if isBlackSquare is true, and set the color to white when isBlackSquare is false.
                Gizmos.color = isBlackSquare ? Color.black : Color.white;

                // Draw a wire cube so the pieces can be seen through the squares.
                Gizmos.DrawWireCube(new Vector2(i, j), new Vector2(1, 1));
            }
        }
    }
}
