using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[InitializeOnLoad]
public static class StartupSceneLoader
{
    // TODO: CHANGE THIS STRING to the path of the scene you want to open
    // You can right-click your scene in the Project view and select "Copy Path"
    private const string scenePath = "Assets/Scenes/SampleScene.unity";

    static StartupSceneLoader()
    {
        // We hook into the update loop once to ensure the editor is fully ready
        EditorApplication.delayCall += LoadSceneOnStart;
    }

    static void LoadSceneOnStart()
    {
        // Remove the callback so it doesn't run again
        EditorApplication.delayCall -= LoadSceneOnStart;

        // 1. Check if we are already playing (don't interrupt play mode)
        if (EditorApplication.isPlaying) return;

        // 2. Check SessionState
        // This prevents the scene from reloading every time you modify a script (recompile)
        // The "FirstLoad" key is cleared only when you close and reopen Unity
        bool alreadyLoaded = SessionState.GetBool("FirstLoad", false);

        if (!alreadyLoaded)
        {
            // Validate path exists to prevent errors
            if (System.IO.File.Exists(scenePath))
            {
                EditorSceneManager.OpenScene(scenePath);
                SessionState.SetBool("FirstLoad", true);
                Debug.Log($"<color=green><b>[Startup]</b></color> Automatically opened: {scenePath}");
            }
            else
            {
                Debug.LogError($"<b>[Startup]</b> Could not find scene at path: {scenePath}. Check your string path.");
            }
        }
    }
}