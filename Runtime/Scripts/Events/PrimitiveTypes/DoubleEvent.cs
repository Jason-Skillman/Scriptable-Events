namespace ScriptableEvents.Events {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Double Event", menuName = "Scriptable Events/Primitive Types/Double Event", order = 14)]
	public class DoubleEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<double> OnInvoked;

		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(double value) => OnInvoked?.Invoke(value);
	}
}
