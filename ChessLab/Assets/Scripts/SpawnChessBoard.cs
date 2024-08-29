using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChessBoard : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        int width = 8;
        int height = 8;

        for (int i = 0; i < width; i ++)
        {
            for (int j = 0; j < height; j++)
            {
                Gizmos.color = new Color(0, 0, 0);
                Gizmos.DrawWireCube(new Vector2(i, j), new Vector2(1, 1));
            }
        }
    }
}
