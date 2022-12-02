namespace JasonSkillman.ScriptableEvents.Editor {
	using System.IO;
	using System.Linq;
	using UnityEditor;
	using UnityEditor.SceneManagement;
	using UnityEngine.SceneManagement;
	
	[CustomEditor(typeof(SceneEvent), true)]
    public class SceneEventEditor : Editor {
    
    	private const string NO_SCENES_WARNING = "No scene has been selected. Use the drop down to select a scene from the build settings.";
    
    	private SceneEvent sceneEvent;
    
    	private string[] scenes;
    
    	private void OnEnable() {
    		sceneEvent = target as SceneEvent;
    		scenes = FetchAllScenesInBuild();
    	}
    
    	public override void OnInspectorGUI() {
    		//base.OnInspectorGUI();
    		DrawScenePicker(scenes);
    	}
    
    	/// <summary>
    	/// Fetches all of the scenes in the current build settings.
    	/// </summary>
    	/// <returns>The array of scene names.</returns>
    	private string[] FetchAllScenesInBuild() {
    		var sceneCount = SceneManager.sceneCountInBuildSettings;
    		string[] buildScenes = new string[sceneCount];
    		for(int i = 0; i < sceneCount; i++) {
    			buildScenes[i] = Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(i));
    		}
    		return buildScenes;
    	}
    
    	/// <summary>
    	/// Draws the popup view with all of the scenes.
    	/// </summary>
    	/// <param name="allScenes"></param>
    	private void DrawScenePicker(string[] allScenes) {
    		var sceneName = sceneEvent.sceneName;
    		EditorGUI.BeginChangeCheck();
    		var selectedScene = allScenes.ToList().IndexOf(sceneName);
    		
    		selectedScene = EditorGUILayout.Popup("Scene", selectedScene, allScenes);
    		if(EditorGUI.EndChangeCheck()) {
    			Undo.RecordObject(target, "Changed selected scene");
    			sceneEvent.sceneName = allScenes[selectedScene];
    			EditorUtility.SetDirty(target);
    			EditorSceneManager.MarkAllScenesDirty();
    		}
    		
    		if(selectedScene < 0) {
    			EditorGUILayout.HelpBox(NO_SCENES_WARNING, MessageType.Warning);
    		}
    	}
    
    }
}
