using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace OneM.Attributes.Editor
{
    [CustomPropertyDrawer(typeof(ReadonlyAttribute))]
    public sealed class ReadonlyAttributeDrawer : PropertyDrawer
    {
        #region Legacy IMUI (Immediate Mode UI) approach (for fallback compatibility)
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, label, true);
            GUI.enabled = true;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) =>
            EditorGUI.GetPropertyHeight(property, label, includeChildren: true);
        #endregion

        #region Modern UI Toolkit approach (Unity 2021.3+)
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var field = new PropertyField(property);

            field.BindProperty(property);
            field.SetEnabled(false);

            return field;
        }
        #endregion
    }
}