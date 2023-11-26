using UnityEngine;
using UnityEditor;
using UnityEngine.Networking;
using System;
using System.Collections;

public class MeetAndTalkProBenefits : EditorWindow
{

    [MenuItem("Meet and Talk/Benefits of Meet and Talk Pro")]
    public static void ShowWindow()
    {
        EditorWindow window = GetWindow<MeetAndTalkProBenefits>(true, "Benefits of Meet and Talk Pro");

        window.position = new Rect(710, 165, 300, 600);
        window.minSize = new Vector2(300, 600);
        window.maxSize = new Vector2(300, 600);

        window.ShowPopup();
    }

    public void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Features", EditorStyles.boldLabel, GUILayout.Width(188));
        EditorGUILayout.LabelField("Free", EditorStyles.centeredGreyMiniLabel, GUILayout.Width(50));
        EditorGUILayout.LabelField("Pro", EditorStyles.centeredGreyMiniLabel, GUILayout.Width(50));
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Separator();

        DrawFree("Start Node");
        DrawFree("Dialogue Node");
        DrawFree("Choice Node");
        DrawFree("End Node");
        DrawFree("Skip Button");
        DrawFree("Random Start");
        DrawFree("Localization");
        DrawFree("Audio in Dialogue");
        DrawFree("Auto Save");

        DrawPro("Event Node");
        DrawPro("Timer Choice Node");
        DrawPro("Random Node");
        DrawPro("Comment Node");
        DrawPro("Type Writing Animation");
        DrawPro("Custom Inspectors");
        DrawPro("Start By ID");
        DrawPro("Characte Avatar");
        DrawPro("Character Emotions");
        
        if(GUILayout.Button("Meet and Talk - Pro Version\nAsset Store", GUILayout.Height(62.5f)))
        {
            Application.OpenURL("https://u3d.as/30sy");
        }
    }

    void DrawPro(string Name)
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField(Name);
        EditorGUILayout.LabelField(EditorGUIUtility.IconContent("d_P4_CheckOutRemote"), GUILayout.Width(50));   // Yes
        EditorGUILayout.LabelField(EditorGUIUtility.IconContent("d_P4_DeletedLocal"), GUILayout.Width(35));     // No
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Separator();
    }
    void DrawFree(string Name)
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField(Name);
        EditorGUILayout.LabelField(EditorGUIUtility.IconContent("d_P4_CheckOutRemote"), GUILayout.Width(50));   // Yes
        EditorGUILayout.LabelField(EditorGUIUtility.IconContent("d_P4_CheckOutRemote"), GUILayout.Width(35));   // Yes
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Separator();
    }
}
