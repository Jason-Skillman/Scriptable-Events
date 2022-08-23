namespace ScriptableEvents.Events {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Bool Event", menuName = "Scriptable Events/Primitive Types/Bool Event", order = 16)]
	public class BoolEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<bool> OnInvoked;

		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(bool value) => OnInvoked?.Invoke(value);
	}
}
