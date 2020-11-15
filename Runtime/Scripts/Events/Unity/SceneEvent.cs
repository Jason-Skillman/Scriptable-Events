using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Scene Event", menuName = "Scriptable Events/Unity/Scene Event", order = 2)]
	public class SceneEvent : ScriptableObject {
		
		public string sceneName;

		/// <summary>
		/// Event called when the scriptable event scene's LoadScene() method is called.
		/// </summary>
		public event UnityAction<string, LoadSceneMode> OnLoadScene;
		
		/// <summary>
		/// Event called when the scriptable event scene's UnloadScene() method is called.
		/// </summary>
		public event UnityAction<string> OnUnloadScene;

		/// <summary>
		/// Main method to call to load the scene.
		/// </summary>
		public void LoadScene(LoadSceneMode mode = LoadSceneMode.Additive) => OnLoadScene?.Invoke(sceneName, mode);
		
		/// <summary>
		/// Main method to call to unload the scene.
		/// </summary>
		public void UnloadScene() => OnUnloadScene?.Invoke(sceneName);
	}
}