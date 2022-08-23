namespace ScriptableEvents.Events {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "String Event", menuName = "Scriptable Events/Primitive Types/String Event", order = 17)]
	public class StringEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<string> OnInvoked;

		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(string value) => OnInvoked?.Invoke(value);
	}
}
