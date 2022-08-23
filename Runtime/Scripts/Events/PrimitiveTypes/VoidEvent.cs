namespace ScriptableEvents.Events {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Void Event", menuName = "Scriptable Events/Primitive Types/Void Event", order = 11)]
	public class VoidEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction OnInvoked;

		public void Invoke() => OnInvoked?.Invoke();
	}
}
