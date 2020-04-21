using UnityEngine;
using UnityEditor;

namespace pf35301.Extensions.Editor {
#if UNITY_EDITOR

    [CustomPropertyDrawer(typeof(PrefabFieldAttribute))]
    public class PrefabFieldDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            if(property.objectReferenceValue != null) {
                var prefabAssetType = PrefabUtility.GetPrefabAssetType(property.objectReferenceValue);
                switch(prefabAssetType) {
                    case PrefabAssetType.NotAPrefab:
                        property.objectReferenceValue = null;
                        break;
                    default:
                        break;
                }
            }

            label.text += " (Prefab Only)";
            EditorGUI.PropertyField(position, property, label);
        }
    }

#endif
}