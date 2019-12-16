using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Animations;

[CustomPropertyDrawer(typeof(DialogBehaviour))]
public class DialogDrawer : PropertyDrawer
{
    public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
    {
        int fieldCount = 0;
        return fieldCount * EditorGUIUtility.singleLineHeight;
    }

    public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
    {

        Rect singleFieldRect = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
    }
}
