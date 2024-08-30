using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Handle : MonoBehaviour
{
    public float value = 7.0f;
}

// A tiny custom editor for ExampleScript component
[CustomEditor(typeof(Handle))]
public class ExampleEditor : Editor
{
    // Custom in-scene UI for when ExampleScript
    // component is selected.
    public void OnSceneGUI()
    {
        var t = target as Handle;
        var tr = t.transform;
        var pos = tr.position;
        // display an orange disc where the object is
        var color = new Color(1, 0.8f, 0.4f, 1);
        Handles.color = color;
        Handles.DrawWireDisc(pos, new Vector3(0, 0, 1), 0.5f);
        // display object "value" in scene
        GUI.color = color;
        Handles.Label(pos, t.value.ToString("F1"));
    }
}