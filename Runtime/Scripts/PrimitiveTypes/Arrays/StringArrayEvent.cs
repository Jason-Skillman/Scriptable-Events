namespace JasonSkillman.ScriptableEvents {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "String Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/String Array Event", order = 6)]
	public class StringArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<string[]> OnInvoked;

		public void Invoke(string[] value) => OnInvoked?.Invoke(value);
	}
}
