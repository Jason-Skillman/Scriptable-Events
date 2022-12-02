namespace JasonSkillman.ScriptableEvents {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Int Event", menuName = "Scriptable Events/Primitive Types/Int Event", order = 12)]
	public class IntEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<int> OnInvoked;

		public void Invoke(int value) => OnInvoked?.Invoke(value);
	}
}
