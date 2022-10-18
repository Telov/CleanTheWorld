using UnityEditor;
using UnityEngine;

namespace Gameplay.Level.Editor
{
    [CustomPropertyDrawer(typeof(GOChancePair))]
    public class GOChancePairDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            {
                var GORect = new Rect(position.x, position.y, 150, position.height);
                var SliderRect = new Rect(position.x + 160, position.y, 150, position.height);

                EditorGUI.PropertyField(GORect, property.FindPropertyRelative("go"), GUIContent.none);
                EditorGUI.PropertyField(SliderRect, property.FindPropertyRelative("chance"), GUIContent.none);
                //EditorGUI.Slider(SliderRect, property.FindPropertyRelative("chance"), 0f, 100f, GUIContent.none);
                //EditorGUI.PropertyField(SliderRect, property.FindPropertyRelative("chance"), GUIContent.none);
            }
            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}