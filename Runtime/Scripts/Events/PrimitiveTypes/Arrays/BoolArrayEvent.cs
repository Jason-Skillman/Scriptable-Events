namespace ScriptableEvents.Events {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Bool Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Bool Array Event", order = 5)]
	public class BoolArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<bool[]> OnInvoked;

		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(bool[] value) => OnInvoked?.Invoke(value);
	}
}
