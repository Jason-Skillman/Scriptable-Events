namespace JasonSkillman.ScriptableEvents {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Event", menuName = "Scriptable Events/Primitive Types/Event", order = 11)]
	public class Event : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction OnInvoked;

		public void Invoke() => OnInvoked?.Invoke();
	}
}
