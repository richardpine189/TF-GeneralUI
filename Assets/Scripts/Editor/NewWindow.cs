
using UnityEditor;
using UnityEngine;

public class HUDScenes : EditorWindow
{
    [MenuItem("NewTools/Aritmics/HUDScenes")]
    static void ShowWindow()
    {
        HUDScenes window = (HUDScenes)GetWindow(typeof(HUDScenes));
        window.minSize = new Vector2(200, 600);
        window.Show();
    }
    
}
public class HUDElements : EditorWindow
{

[MenuItem("NewTools/Aritmics/HUDElements")]
    static void ShowWindow()
    {
        HUDElements window = (HUDElements)GetWindow(typeof(HUDElements));
        window.minSize = new Vector2(600, 200);
        window.Show();
    }
}
