using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChessBoard : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        for (int i = 0; i < 8; i ++)
        {
            for (int j = 0; j < 8; j++)
            {
                Gizmos.color = new Color(0, 0, 0);
                Gizmos.DrawWireCube(new Vector3(j + (i * 2), j, j), new Vector3(1, 1, 1));
            }
        }
        

        //for (int i = 0; i < 4; i ++)
        //{
        //    int loopsWhiteSquares = 7;
        //    loopsWhiteSquares = loopsWhiteSquares - 2;

        //    for (int j = 0; j < loopsWhiteSquares; j++)
        //    {
        //        Gizmos.color = new Color(1, 1, 1);
        //        Gizmos.DrawWireCube(new Vector3(j + 1, j, j), new Vector3(1, 1, 1));
        //    }
        //}
        
    }
}
