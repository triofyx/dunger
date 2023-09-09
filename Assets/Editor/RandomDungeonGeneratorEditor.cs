using Dunger;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Dungeon), true)]
public class DungeonGeneratorEditor : Editor
{
    Dungeon generator;

    private void Awake()
    {
        generator = (Dungeon)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Create Dungeon"))
        {
            generator.GenerateDungeon();
        }
        if (GUILayout.Button("Remove Roof"))
        {
            generator.RemoveRoof();
        }
    } 
}
