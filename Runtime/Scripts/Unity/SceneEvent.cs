namespace JasonSkillman.ScriptableEvents {
	using UnityEngine;
	using UnityEngine.Events;
	using UnityEngine.SceneManagement;

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

		public void LoadScene(LoadSceneMode mode = LoadSceneMode.Additive) => OnLoadScene?.Invoke(sceneName, mode);

		public void UnloadScene() => OnUnloadScene?.Invoke(sceneName);
	}
}
