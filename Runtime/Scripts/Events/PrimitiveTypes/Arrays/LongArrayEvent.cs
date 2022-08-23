namespace ScriptableEvents.Events {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Long Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Long Array Event", order = 4)]
	public class LongArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<long[]> OnInvoked;

		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(long[] value) => OnInvoked?.Invoke(value);
	}
}
