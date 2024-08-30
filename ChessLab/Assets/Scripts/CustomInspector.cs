
using UnityEditor;
using UnityEngine;

namespace UnityEditor
{
    [CustomEditor(typeof(GameObject))]
    public class CustomInspector : Editor
    {
        private GameObject[] bottomRow; //For the collection of bottom row pieces
        private GameObject[] topRow; //For the collection of top row pieces

        public void OnEnable()
        {

            
            bottomRow = GameObject.FindGameObjectsWithTag("BottomRow");  // Bottom row chess pieces are identified with the tag "BottomRow"
            topRow = GameObject.FindGameObjectsWithTag("TopRow"); //Top row chess pieces are identified with the tag "TopRow
        }

        public void OnSceneGUI()
        {
            if (Event.current.type == EventType.Repaint)
            {
                //Adds an outline for both bottom and top rows with different colors.
                Handles.DrawOutline(bottomRow, Color.yellow, Color.green, 0.1f);
                Handles.DrawOutline(topRow, Color.blue, Color.green, 0.1f);

            }
        }
    }
}