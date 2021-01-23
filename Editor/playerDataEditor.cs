using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CustumPackage
{
    [CustomEditor(typeof(PlayerData))]
    public class playerDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.Space();

            if (GUILayout.Button("chlik"))
            {
                Debug.Log("");
            }
        }


    }
}
