#if UNITY_EDITOR

namespace PTK.Palette
{
    using System.Collections;
    using UnityEngine;
    using UnityEditor;

    [CustomEditor(typeof(SpritePalette))]
    public class SpritePaletteEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            SpritePalette plt = (SpritePalette)target;
            if (GUILayout.Button("Update palette"))
                plt.UpdatePalette();
        }
    }
}
#endif