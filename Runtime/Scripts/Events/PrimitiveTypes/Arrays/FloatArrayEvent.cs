namespace ScriptableEvents.Events {
	using UnityEngine;
	using UnityEngine.Events;

	[CreateAssetMenu(fileName = "Float Array Event", menuName = "Scriptable Events/Primitive Types/Arrays/Float Array Event", order = 2)]
	public class FloatArrayEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<float[]> OnInvoked;

		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(float[] value) => OnInvoked?.Invoke(value);
	}
}
