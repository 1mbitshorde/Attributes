using UnityEngine;
using UnityEditor;

namespace OneM.Attributes.Editor
{
    [CustomPropertyDrawer(typeof(ShowIfAttribute))]
    public class ShowIfAttributeDrawer : AbstractComparableAttributeDrawer<ShowIfAttribute>
    {
        private bool isConditionMet;

        public override float GetPropertyHeight(SerializedProperty property, GUIContent _) => isConditionMet ?
            EditorGUI.GetPropertyHeight(property, includeChildren: true) : 0f;

        protected override void DrawProperty(bool isConditionMet, Rect position, SerializedProperty property, GUIContent label)
        {
            this.isConditionMet = isConditionMet;
            if (isConditionMet) EditorGUI.PropertyField(position, property, label, includeChildren: true);
        }
    }
}