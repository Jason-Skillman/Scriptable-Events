using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Events {
	[CreateAssetMenu(fileName = "Float Event", menuName = "Scriptable Events/Primitive Types/Float Event", order = 13)]
	public class FloatEvent : ScriptableObject {
		/// <summary>
		/// Event called when the scriptable event is invoked.
		/// </summary>
		public event UnityAction<float> OnInvoked;
		
		/// <summary>
		/// Invokes the event.
		/// </summary>
		public void Invoke(float value) => OnInvoked?.Invoke(value);
	}
}